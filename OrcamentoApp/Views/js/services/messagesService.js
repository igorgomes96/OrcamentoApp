angular.module('orcamentoApp').service('messagesService', ['$timeout', function($timeout) {
	
	var self = this;

	self.exibeMensagemErro = function(statusCode, mensagem) {

		var m = '<div class="mensagem-error">';

		if (statusCode)
			m = m + '<strong>Erro ' + statusCode + '!</strong><br>' + mensagem + '</div>';
		else
			m = m + '<strong>Erro ao processar informações!</strong><br>' + mensagem + '</div>';


		$('.mensagem-error').remove();
		$('body').append(m);
		$('.mensagem-error').fadeIn('slow');

		$timeout(function() {
			$('.mensagem-error').fadeOut('slow');
		}, 6000);
	}

	self.exibeMensagemSucesso = function(mensagem) {
		mensagem = '<div class="mensagem-success"><strong>Sucesso ao processar solicitação!</strong><br>' + mensagem + '</div>';

		$('.mensagem-success').remove();
		$('body').append(mensagem);
		$('.mensagem-success').fadeIn('slow');

		$timeout(function() {
			$('.mensagem-success').fadeOut('slow');
		}, 6000);
	}

}])