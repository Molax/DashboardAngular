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
        $scope.corDefinida = 70;

        $scope.gauge = {
            value: 50,
            width: 300,
            height: 300
        };





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


        //AtualizaVelocimetros
        apiService.get("Dash/AtualizaVelocimetros", null, succeAtualizaVelocimetros, erroAtualizaVelocimetros);

        function succeAtualizaVelocimetros(res) {

            $scope.AtualizaVelocimetros = res.data;


            var gaugeOptions = {

                chart: {
                    type: 'solidgauge'
                },

                title: null,

                pane: {
                    center: ['50%', '85%'],
                    size: '140%',
                    startAngle: -90,
                    endAngle: 90,
                    background: {
                        backgroundColor: (Highcharts.theme && Highcharts.theme.background2) || '#EEE',
                        innerRadius: '60%',
                        outerRadius: '100%',
                        shape: 'arc'
                    }
                },

                tooltip: {
                    enabled: false
                },

                // the value axis
                yAxis: {
                    stops: [
                        [0.1, '#55BF3B'], // green
                        [0.5, '#DDDF0D'], // yellow
                        [0.9, '#DF5353'] // red
                    ],
                    lineWidth: 0,
                    minorTickInterval: null,
                    tickAmount: 2,
                    title: {
                        y: -70
                    },
                    labels: {
                        y: 16
                    }
                },

                plotOptions: {
                    solidgauge: {
                        dataLabels: {
                            y: 5,
                            borderWidth: 0,
                            useHTML: true
                        }
                    }
                }
            };
            debugger;
            var x = parseInt(res.data[0].Valor);

            $('#container-rpm').highcharts(Highcharts.merge(gaugeOptions, {
                yAxis: {
                    min: 0,
                    max: 100,
                    title: {
                        text: res.data[0].Dado
                    }
                },

                series: [{
                    name: 'RPM',
                    data: x,
                    dataLabels: {
                        format: '<div style="text-align:center"><span style="font-size:25px;color:' +
                            ((Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black') + '">{y:.1f}</span><br/>' +
                               '<span style="font-size:12px;color:silver">Porcentagem</span></div>'
                    },
                    tooltip: {
                        valueSuffix: ' revolutions/min'
                    }
                }]

            }));


        }

        function erroAtualizaVelocimetros(res) {

        }


        setInterval(function () {
            $scope.Dashboard();
        }, 5000);

        setInterval(function () {

            apiService.get("Dash/AtualizaVelocimetros", null, suc, er);

            function suc(res) {
                chart = $('#container-rpm').highcharts();
                if (chart) {
                    debugger;
                    point = chart.series[0].points[0];


                    point.update(parseInt(res.data[0].Valor));
                }
            }

            function er(res) {
            }

        }, 2000);

    }
})(angular.module('TRESTTO'));