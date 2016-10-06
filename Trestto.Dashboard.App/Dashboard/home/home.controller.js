/// <reference path="home.controller.js" />
(function (app) {
    app.controller('homeCtrl', homeCtrl);

    homeCtrl.$inject = ["$scope", "$location", "apiService"];

    function homeCtrl($scope, $location, apiService) {

        function successAtualizaPainelHoraHora(res) {

            console.log(res.data);

        }

        function errorAtualizaPainelHoraHora(res) {

        }

        apiService.get("Dash/AtualizaPainelHoraHora", null, successAtualizaPainelHoraHora, errorAtualizaPainelHoraHora);

        $scope.FODASEE = 'IFUDEI';
    }
})(angular.module('TRESTTO'));