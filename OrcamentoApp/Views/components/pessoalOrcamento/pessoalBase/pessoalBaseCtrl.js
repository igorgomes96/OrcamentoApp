angular.module('orcamentoApp').controller('pessoalBaseCtrl', ['messagesService', 'transferenciasAPI', 'funcionariosAPI', '$scope', 'sharedDataService', 'cargosAPI', '$rootScope', function(messagesService, transferenciasAPI, funcionariosAPI, $scope, sharedDataService, cargosAPI, $rootScope) {
	var self = this;

    self.cr = null;
    self.funcionarioTransf = null;

	var loadFuncionarios = function(cr) {
        funcionariosAPI.getFuncionarios(cr)
        .then(function(dado) {
            self.funcionarios = dado.data;

            self.funcionarios.forEach(function(x) {
                cargosAPI.getCargo(x.CargoCod)
                .then(function(dado2){
                    x.Cargo = dado2.data;
                });
            });
        }, function(error) {
            console.log(error);
        });
    }

    self.save = function(funcionarios) {
        var cont = 0; total = funcionarios.length;
    	funcionarios.forEach(function(x) {
            funcionariosAPI.putFuncionario(x.Matricula, x);
    	});
        messagesService.exibeMensagemSucesso("Alterações salvas com sucesso!");
    }
    
    self.salvarTransferencia = function(transf) {
        var copia = angular.copy(transf.Funcionario);
        delete transf.Funcionario;
        transferenciasAPI.postTransferencia(transf)
        .then(function(dado) {
            messagesService.exibeMensagemSucesso("Solicitação de Transferência enviada com sucesso!");
            $('#modal-tranferir-cr').fadeOut();
            $('.modal-backdrop').fadeOut();
            $('body').removeClass('modal-open');
            $rootScope.$broadcast('transCREvent');
        }, function(error) {
            transf.Funcionario = copia;
        });
    }

    self.transferir = function(funcionario) {
        self.funcionarioTransf = {
            CRDestino: "",
            FuncionarioMatricula: funcionario.Matricula,
            Funcionario: funcionario,
            Status: "Aguardando Aprovação",
            DataSolicitacao: new Date(),
            MesTransferencia: self.ciclo.Meses[0].Codigo
        }
    }

    self.verificarFerias = function(funcionario) {
    	if (!funcionario.MesFerias) return;
    	if (funcionario.MesFerias > funcionario.MesDesligamento)
    		funcionario.MesFerias = null;
    }

    self.verificarDesligamento = function(funcionario) {
    	if (!funcionario.MesDesligamento) return;
    	if (funcionario.MesFerias > funcionario.MesDesligamento)
    		funcionario.MesDesligamento = null;
    }


    //Adiciona um listener para capturar as mudanças de seleção de CR
    var listener = $scope.$on('crChanged', function($event, cr) {
        if (cr) {
            self.cr = cr;
            loadFuncionarios(cr.Codigo);
        }
        else
            self.funcionarios = [];
    });

    //Remove o Listener
    $scope.$on('$destroy', function () {
        listener();
    });


    //loadFuncionarios();
    self.ciclo = sharedDataService.getCicloAtual();


}]);