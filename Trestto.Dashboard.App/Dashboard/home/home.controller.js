/// <reference path="home.controller.js" />
(function (app) {
    app.controller('homeCtrl', homeCtrl);

    homeCtrl.$inject = ["$scope", "$location", "apiService"];

    function homeCtrl($scope, $location, apiService) {


        $scope.AtualizaPainelHoraHora = {};
        $scope.AtualizaPainelHoraHoraTotal = {};
        $scope.AtualizaPainelHoraHoraPercentual = {};
        $scope.AtualizaPainelHoraHoraPercentualTotal = {};
        $scope.AtualizaPainelTelefonia = {};
        $scope.AtualizaGraficoTelefonia = {};
        $scope.AtualizaProdutividadeAgentes = {};
        $scope.AtualizaMonitoramentoCanais = {};
        $scope.AtualizaVelocimetros = {};
        $scope.AtualizaControleMailing = {};
        $scope.AtualizaControleMailingGrafico = {};
        $scope.AtualizaConversaoCPC = {};

        $scope.Dashboard = function () {

            //AtualizaPainelHoraHora
            apiService.get("Dash/AtualizaPainelHoraHora", null, successAtualizaPainelHoraHora, errorAtualizaPainelHoraHora);

            function successAtualizaPainelHoraHora(res) {

                $scope.AtualizaPainelHoraHora = res.data;

            }

            function errorAtualizaPainelHoraHora(res) {

            }


            //AtualizaPainelHoraHoraTotal
            apiService.get("Dash/AtualizaPainelHoraHoraTotal", null, successAtualizaPainelHoraHoraAtualizaPainelHoraHoraTotal, errorAtualizaPainelHoraHoraTotal);

            function successAtualizaPainelHoraHoraAtualizaPainelHoraHoraTotal(res) {

                $scope.AtualizaPainelHoraHoraTotal = res.data;
                console.log(res.data)
            }

            function errorAtualizaPainelHoraHoraTotal(res) {

            }


            //AtualizaPainelHoraHoraPercentual
            apiService.get("Dash/AtualizaPainelHoraHoraPercentual", null, successAtualizaPainelHoraHoraPercentual, errorAtualizaPainelHoraHoraPercentual);

            function successAtualizaPainelHoraHoraPercentual(res) {

                $scope.AtualizaPainelHoraHoraPercentual = res.data;
                console.log(res.data)
            }

            function errorAtualizaPainelHoraHoraPercentual(res) {

            }


            //AtualizaPainelHoraHoraPercentualTotal
            apiService.get("Dash/AtualizaPainelHoraHoraPercentualTotal", null, successAtualizaPainelHoraHoraPercentualTotal, errorAtualizaPainelHoraHoraPercentualTotal);

            function successAtualizaPainelHoraHoraPercentualTotal(res) {

                $scope.AtualizaPainelHoraHoraPercentualTotal = res.data;
                console.log(res.data)
            }

            function errorAtualizaPainelHoraHoraPercentualTotal(res) {

            }


            //AtualizaPainelTelefonia
            apiService.get("Dash/AtualizaPainelTelefonia", null, successAtualizaPainelTelefoniaal, errorAAtualizaPainelTelefonia);

            function successAtualizaPainelTelefoniaal(res) {

                $scope.AtualizaPainelTelefonia = res.data;
                console.log(res.data)
            }

            function errorAAtualizaPainelTelefonia(res) {

            }



            //AtualizaPainelTelefonia
            apiService.get("Dash/AtualizaGraficoTelefonia", null, successAtualizaGraficoTelefonia, errorAtualizaGraficoTelefonia);

            function successAtualizaGraficoTelefonia(res) {

                $scope.AtualizaGraficoTelefonia = res.data;
                console.log(res.data)
            }

            function errorAtualizaGraficoTelefonia(res) {

            }


            //AtualizaProdutividadeAgentes
            apiService.get("Dash/AtualizaProdutividadeAgentes", null, succesAtualizaProdutividadeAgentes, errorAtualizaProdutividadeAgentes);

            function succesAtualizaProdutividadeAgentes(res) {

                $scope.AtualizaProdutividadeAgentes = res.data;
                console.log(res.data)
            }

            function errorAtualizaProdutividadeAgentes(res) {

            }


            //AtualizaMonitoramentoCanais
            apiService.get("Dash/AtualizaMonitoramentoCanais", null, succesAtualizaMonitoramentoCanais, erroAtualizaMonitoramentoCanais);

            function succesAtualizaMonitoramentoCanais(res) {

                $scope.AtualizaMonitoramentoCanais = res.data;
                console.log(res.data)
            }

            function erroAtualizaMonitoramentoCanais(res) {

            }



            //AtualizaVelocimetros
            apiService.get("Dash/AtualizaVelocimetros", null, succeAtualizaVelocimetros, erroAtualizaVelocimetros);

            function succeAtualizaVelocimetros(res) {

                $scope.AtualizaVelocimetros = res.data;
                console.log(res.data)
            }

            function erroAtualizaVelocimetros(res) {

            }


            //AtualizaControleMailing
            apiService.get("Dash/AtualizaControleMailing", null, succeAtualizaControleMailing, errorAtualizaControleMailing);

            function succeAtualizaControleMailing(res) {

                $scope.AtualizaControleMailing = res.data;
                console.log(res.data)
            }

            function errorAtualizaControleMailing(res) {

            }


            //AtualizaControleMailingGrafico
            apiService.get("Dash/AtualizaControleMailingGrafico", null, succesAtualizaControleMailingGrafico, errorAtualizaControleMailingGrafico);

            function succesAtualizaControleMailingGrafico(res) {

                $scope.AtualizaControleMailingGrafico = res.data;
                console.log(res.data)
            }

            function errorAtualizaControleMailingGrafico(res) {

            }


            //AtualizaConversaoCPC
            apiService.get("Dash/AtualizaConversaoCPC", null, succesAtualizaConversaoCPC, errorAtualizaConversaoCPC);

            function succesAtualizaConversaoCPC(res) {

                $scope.AtualizaConversaoCPC = res.data;
                console.log(res.data)
            }

            function errorAtualizaConversaoCPC(res) {

            }
        }


        $scope.Dashboard();

        setInterval(function () {
            $scope.Dashboard();
        }, 10000);

    }
})(angular.module('TRESTTO'));