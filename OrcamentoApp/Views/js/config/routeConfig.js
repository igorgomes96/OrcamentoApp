angular.module('orcamentoApp').config(['$stateProvider', '$urlRouterProvider', '$locationProvider', function($stateProvider, $urlRouterProvider, $locationProvider) {

    $locationProvider.hashPrefix('');
    $urlRouterProvider.otherwise('/autenticacao');
    
    $stateProvider

    .state('autenticacao', {
        url: '/autenticacao',
        templateUrl: 'Views/components/autenticacao/autenticacao.html',
        controller: 'autenticacaoCtrl as ct'
    })

    .state('home', {
        url: '/home',
        templateUrl: 'Views/components/home/homeAdministrador.html'//,
        //controller: 'autenticacaoCtrl as ct'
    })

    .state('menuContainer', {
        templateUrl: 'Views/components/menuContainer/menuContainer.html'
    })

    .state('menuContainer.dashboard', {
        url: '/dashboard',
        templateUrl: 'Views/components/dashboard/dashboard.html',
        controller: 'dashboardCtrl as ct'
    })

    .state('menuContainer.unauthenticated', {
        url: '/unauthenticated',
        templateUrl: 'Views/components/autenticacao/unauthenticated.html'
    })

    .state('menuContainer.pessoalOrcamento', {
        url: '/pessoalOrcamento/:codCiclo',
        views: {
            '': {
                templateUrl: 'Views/components/pessoalOrcamento/pessoalOrcamento.html', 
                controller: 'pessoalOrcamentoCtrl as ctMain'
            },
            'pessoalBase@menuContainer.pessoalOrcamento': {
                templateUrl: 'Views/components/pessoalOrcamento/pessoalBase/pessoalBase.html', 
                controller: 'pessoalBaseCtrl as ct'
            },
            'pessoalContratacoes@menuContainer.pessoalOrcamento': {
                templateUrl: 'Views/components/pessoalOrcamento/pessoalContratacoes/pessoalContratacoes.html', 
                controller: 'pessoalContratacoesCtrl as ct'
            },
            'pessoalTransferenciasEnviadas@menuContainer.pessoalOrcamento': {
                templateUrl: 'Views/components/pessoalOrcamento/pessoalTransferencias/pessoalTransferenciasEnviadas.html', 
                controller: 'pessoalTransferenciasCtrl as ct'
            },
            'pessoalTransferenciasRecebidas@menuContainer.pessoalOrcamento': {
                templateUrl: 'Views/components/pessoalOrcamento/pessoalTransferencias/pessoalTransferenciasRecebidas.html', 
                controller: 'pessoalTransferenciasCtrl as ct'
            }
        },
        resolve: {
            cicloResolve: function($stateParams, ciclosAPI) {
                if (!$stateParams.codCiclo) return null;
                return ciclosAPI.getCiclo($stateParams.codCiclo);
            }
        }
    })

    .state('menuContainer.solicitacoesTH', {
        url: '/solicitacoesTH',
        views: {
            '': {
                templateUrl: 'Views/components/solicitacoesTH/solicitacoesTH.html', 
                controller: 'solicitacoesTHCtrl as ctMain'
            },
            'solicitacoes@menuContainer.solicitacoesTH': {
                templateUrl: 'Views/components/solicitacoesTH/solicitacoesTHSolicitacoes/solicitacoesTHSolicitacoes.html', 
            },
            'historico@menuContainer.solicitacoesTH': {
                templateUrl: 'Views/components/solicitacoesTH/solicitacoesTHHistorico/solicitacoesTHHistorico.html', 
                controller: 'solicitacoesTHHistoricoCtrl as ct'
            }
        },
        resolve: {
            pageResolve: function() {
                return 'Histórico';
            }
        }
    })

    .state('menuContainer.simulacoes', {
        url: '/simulacoes',
        views: {
            '': {
                templateUrl: 'Views/components/temp/simulacoes.html'
            }
        }
    })

    .state('menuContainer.filaSolicitacoes', {
        url: '/filaSolicitacoes',
        templateUrl: 'Views/components/solicitacoesTH/solicitacoesTHFila/solicitacoesTHFila.html',
        controller: 'solicitacoesTHHistoricoCtrl as ct',
        resolve: {
            pageResolve: function() {
                return 'Fila';
            }
        }       
    })

    .state('menuContainer.premissasEncargos', {
        url: '/premissasEncargos',
        views: {
            '': {
                templateUrl: 'Views/components/premissas/encargos/encargos.html', 
                controller: 'premissasCtrl as ctMain'
            },
            'porEmpresa@menuContainer.premissasEncargos': {
                templateUrl: 'Views/components/premissas/encargos/encargosPorEmpresa.html', 
                controller: 'encargosPorEmpresaCtrl as ct'
            },
            'porFilial@menuContainer.premissasEncargos': {
                templateUrl: 'Views/components/premissas/encargos/encargosPorFilial.html', 
                controller: 'encargosPorFilialCtrl as ct'
            }
        }
    })

    .state('menuContainer.premissasCargos', {
        url: '/premissasCargos',
        views: {
            '': {
                templateUrl: 'Views/components/premissas/cargosSalarios/premissasCargosSalarios.html', 
                controller: 'premissasCtrl as ctMain'
            },
            'cargos@menuContainer.premissasCargos': {
                templateUrl: 'Views/components/premissas/cargosSalarios/premissasCargos.html', 
                controller: 'premissasCargosCtrl as ct'
            }
        }
    })

    .state('menuContainer.premissasSindicatos', {
        url: '/premissasReajustes',
        views: {
            '': {
                templateUrl: 'Views/components/premissas/sindicatos/premissasSindicatosContainer.html', 
                controller: 'premissasCtrl as ctMain'
            },
            'sindicatos@menuContainer.premissasSindicatos': {
                templateUrl: 'Views/components/premissas/sindicatos/premissasSindicatos.html', 
                controller: 'premissasSindicatosCtrl as ct'
            }
        }
    })

    .state('menuContainer.premissasBeneficios', {
        url: '/premissasBeneficios',
        views: {
            '': {
                templateUrl: 'Views/components/premissas/beneficios/premissasBeneficios.html', 
                controller: 'premissasCtrl as ctMain'
            },
            'variaveis@menuContainer.premissasBeneficios': {
                templateUrl: 'Views/components/premissas/beneficios/premissasVariaveis.html', 
                controller: 'premissasVariaveisCtrl as ct'
            },
            'pat@menuContainer.premissasBeneficios': {
                templateUrl: 'Views/components/premissas/beneficios/premissasPat.html', 
                controller: 'premissasPatCtrl as ct'
            },
            'vt@menuContainer.premissasBeneficios': {
                templateUrl: 'Views/components/premissas/beneficios/premissasVT.html', 
                controller: 'premissasVTCtrl as ct'
            },
            'planosConvenio@menuContainer.premissasBeneficios': {
                templateUrl: 'Views/components/premissas/beneficios/premissasConvenioMedico.html', 
                controller: 'premissasConvenioMedicoCtrl as ct'
            },
            'reajustesConvenio@menuContainer.premissasBeneficios': {
                templateUrl: 'Views/components/premissas/beneficios/premissasReajConvenioMedico.html', 
                controller: 'premissasReajConvenioMedicoCtrl as ct'
            }
        }
    })

    .state('menuContainer.gestaoUsuarios', {
        url: '/gestaoUsuarios',
        views: {
            '': {
                templateUrl: 'Views/components/usuarios/containerUsuarios.html'
            },
            'usuarios@menuContainer.gestaoUsuarios': {
                templateUrl: 'Views/components/usuarios/usuarios.html', 
                controller: 'gestaoUsuariosCtrl as ct'
            }
        }
    });
    
}]);