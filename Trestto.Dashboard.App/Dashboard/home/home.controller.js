/// <reference path="home.controller.js" />
(function (app) {
	app.controller('homeCtrl', homeCtrl);

	homeCtrl.$inject = ["$scope", "$location", "apiService"];

	function homeCtrl($scope, $location, apiService) {
		console.log('foifoifofof');

		function blablasSucess(res) {
			alert(res.data);
		}

		function error(res) {

		}

		apiService.get("home/blablas", null, blablasSucess, error);
         
		$scope.FODASEE = 'IFUDEI';
	}
})(angular.module('TRESTTO'));