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





            //AtualizaPainelHoraHoraPercentual
            apiService.get("Dash/AtualizaPainelHoraHoraPercentual", null, successAtualizaPainelHoraHoraPercentual, errorAtualizaPainelHoraHoraPercentual);

            function successAtualizaPainelHoraHoraPercentual(res) {
                
                $scope.AtualizaPainelHoraHoraPercentual = res.data;

                console.log(res.data)
            }

            function errorAtualizaPainelHoraHoraPercentual(res) {

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
                
                $scope.AtualizaGraficoTelefonia[0].Valor = $scope.AtualizaGraficoTelefonia[0].Valor.toFixed(2);
                $scope.AtualizaGraficoTelefonia[1].Valor = $scope.AtualizaGraficoTelefonia[1].Valor.toFixed(2);
                $scope.AtualizaGraficoTelefonia[2].Valor = $scope.AtualizaGraficoTelefonia[2].Valor.toFixed(2);
                $scope.AtualizaGraficoTelefonia[3].Valor = $scope.AtualizaGraficoTelefonia[3].Valor.toFixed(2);
                $scope.AtualizaGraficoTelefonia[4].Valor = $scope.AtualizaGraficoTelefonia[4].Valor.toFixed(2);
                $scope.AtualizaGraficoTelefonia[5].Valor = $scope.AtualizaGraficoTelefonia[5].Valor.toFixed(2);
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
                console.log($scope.AtualizaConversaoCPC[0])


            }

            function errorAtualizaConversaoCPC(res) {

            }
        }


        $scope.Dashboard();


        //AtualizaVelocimetros
        apiService.get("Dash/AtualizaVelocimetros", null, succeAtualizaVelocimetros, erroAtualizaVelocimetros);

        function succeAtualizaVelocimetros(res) {

            $scope.AtualizaVelocimetros = res.data;

            var x = parseFloat(res.data[0].Valor);

            $('#container').highcharts({

                chart: {
                    type: 'gauge',
                    plotBackgroundColor: null,
                    plotBackgroundImage: null,
                    plotBorderWidth: 0,
                    plotShadow: false
                },

                title: {
                    text: res.data[0].Dado
                },

                pane: {
                    startAngle: -150,
                    endAngle: 150,
                    background: [{
                        backgroundColor: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0, '#FFF'],
                                [1, '#333']
                            ]
                        },
                        borderWidth: 0,
                        outerRadius: '109%'
                    }, {
                        backgroundColor: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0, '#333'],
                                [1, '#FFF']
                            ]
                        },
                        borderWidth: 1,
                        outerRadius: '107%'
                    }, {
                        // default background
                    }, {
                        backgroundColor: '#DDD',
                        borderWidth: 0,
                        outerRadius: '105%',
                        innerRadius: '103%'
                    }]
                },

                // the value axis
                yAxis: {
                    min: 0,
                    max: 100,

                    minorTickInterval: 'auto',
                    minorTickWidth: 1,
                    minorTickLength: 10,
                    minorTickPosition: 'inside',
                    minorTickColor: '#666',

                    tickPixelInterval: 30,
                    tickWidth: 2,
                    tickPosition: 'inside',
                    tickLength: 10,
                    tickColor: '#666',
                    labels: {
                        step: 2,
                        rotation: 'auto'
                    },
                    title: {
                        text: '%'
                    },
                    plotBands: [{
                        from: 0,
                        to: 20,
                        color: '#55BF3B' // green
                    }, {
                        from: 20,
                        to: 60,
                        color: '#DDDF0D' // yellow
                    }, {
                        from: 60,
                        to: 100,
                        color: '#DF5353' // red
                    }]
                },

                series: [{
                    name: 'Porcentagem',
                    data: [x],
                    tooltip: {
                        valueSuffix: ' %'
                    }
                }]

            },
        // Add some life
        function (chart) {
            if (!chart.renderer.forExport) {
                setInterval(function () {
                    apiService.get("Dash/AtualizaVelocimetros", null, suc, er);
                    function suc(data) {
                        var point = chart.series[0].points[0],
                        newVal,
                        inc = parseFloat(data.data[0].Valor);

                        newVal = parseFloat(data.data[0].Valor);
                        point.update(newVal);
                    }
                    function er(data) {
                    }


                }, 4000);
            }
        });
            var y = parseFloat(res.data[1].Valor);
            $('#container2').highcharts({

                chart: {
                    type: 'gauge',
                    plotBackgroundColor: null,
                    plotBackgroundImage: null,
                    plotBorderWidth: 0,
                    plotShadow: false
                },

                title: {
                    text: res.data[1].Dado
                },

                pane: {
                    startAngle: -150,
                    endAngle: 150,
                    background: [{
                        backgroundColor: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0, '#FFF'],
                                [1, '#333']
                            ]
                        },
                        borderWidth: 0,
                        outerRadius: '109%'
                    }, {
                        backgroundColor: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0, '#333'],
                                [1, '#FFF']
                            ]
                        },
                        borderWidth: 1,
                        outerRadius: '107%'
                    }, {
                        // default background
                    }, {
                        backgroundColor: '#DDD',
                        borderWidth: 0,
                        outerRadius: '105%',
                        innerRadius: '103%'
                    }]
                },

                // the value axis
                yAxis: {
                    min: 0,
                    max: 100,

                    minorTickInterval: 'auto',
                    minorTickWidth: 1,
                    minorTickLength: 10,
                    minorTickPosition: 'inside',
                    minorTickColor: '#666',

                    tickPixelInterval: 30,
                    tickWidth: 2,
                    tickPosition: 'inside',
                    tickLength: 10,
                    tickColor: '#666',
                    labels: {
                        step: 2,
                        rotation: 'auto'
                    },
                    title: {
                        text: '%'
                    },
                    plotBands: [{
                        from: 0,
                        to: 20,
                        color: '#55BF3B' // green
                    }, {
                        from: 20,
                        to: 60,
                        color: '#DDDF0D' // yellow
                    }, {
                        from: 60,
                        to: 100,
                        color: '#DF5353' // red
                    }]
                },

                series: [{
                    name: 'Porcentagem',
                    data: [y],
                    tooltip: {
                        valueSuffix: ' %'
                    }
                }]

            },
        // Add some life
        function (chart) {
            if (!chart.renderer.forExport) {
                setInterval(function () {
                    apiService.get("Dash/AtualizaVelocimetros", null, suc, er);
                    function suc(data) {
                        var point = chart.series[0].points[0],
                        newVal,
                        inc = parseFloat(data.data[1].Valor);

                        newVal = parseFloat(data.data[1].Valor);
                        point.update(newVal);
                    }
                    function er(data) {
                    }


                }, 4000);
            }
        });

            var z = parseFloat(res.data[2].Valor);
            $('#container3').highcharts({

                chart: {
                    type: 'gauge',
                    plotBackgroundColor: null,
                    plotBackgroundImage: null,
                    plotBorderWidth: 0,
                    plotShadow: false
                },

                title: {
                    text: res.data[2].Dado
                },

                pane: {
                    startAngle: -150,
                    endAngle: 150,
                    background: [{
                        backgroundColor: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0, '#FFF'],
                                [1, '#333']
                            ]
                        },
                        borderWidth: 0,
                        outerRadius: '109%'
                    }, {
                        backgroundColor: {
                            linearGradient: { x1: 0, y1: 0, x2: 0, y2: 1 },
                            stops: [
                                [0, '#333'],
                                [1, '#FFF']
                            ]
                        },
                        borderWidth: 1,
                        outerRadius: '107%'
                    }, {
                        // default background
                    }, {
                        backgroundColor: '#DDD',
                        borderWidth: 0,
                        outerRadius: '105%',
                        innerRadius: '103%'
                    }]
                },

                // the value axis
                yAxis: {
                    min: 0,
                    max: 100,

                    minorTickInterval: 'auto',
                    minorTickWidth: 1,
                    minorTickLength: 10,
                    minorTickPosition: 'inside',
                    minorTickColor: '#666',

                    tickPixelInterval: 30,
                    tickWidth: 2,
                    tickPosition: 'inside',
                    tickLength: 10,
                    tickColor: '#666',
                    labels: {
                        step: 2,
                        rotation: 'auto'
                    },
                    title: {
                        text: '%'
                    },
                    plotBands: [{
                        from: 0,
                        to: 20,
                        color: '#55BF3B' // green
                    }, {
                        from: 20,
                        to: 60,
                        color: '#DDDF0D' // yellow
                    }, {
                        from: 60,
                        to: 100,
                        color: '#DF5353' // red
                    }]
                },

                series: [{
                    name: 'Porcentagem',
                    data: [z],
                    tooltip: {
                        valueSuffix: ' %'
                    }
                }]

            },
        // Add some life
        function (chart) {
            if (!chart.renderer.forExport) {
                setInterval(function () {
                    apiService.get("Dash/AtualizaVelocimetros", null, suc, er);
                    function suc(data) {
                        var point = chart.series[0].points[0],
                        newVal,
                        inc = parseFloat(data.data[2].Valor);

                        newVal = parseFloat(data.data[2].Valor);
                        point.update(newVal);
                    }
                    function er(data) {
                    }


                }, 4000);
            }
        });

        }

        function erroAtualizaVelocimetros(res) {

        }


        setInterval(function () {
            $scope.Dashboard();
        }, 5000);

        setTimeout(function () {
            
            var xx = parseFloat($scope.AtualizaConversaoCPC[0].Qnt);
            var yy = parseFloat($scope.AtualizaConversaoCPC[1].Qnt);
            var zz = parseFloat($scope.AtualizaConversaoCPC[2].Qnt);

            $('#piechart').highcharts({
                chart: {
                    plotBackgroundColor: null,
                    plotBorderWidth: null,
                    plotShadow: false,
                    type: 'pie'
                },
                title: {
                    text: 'CPC x Atendidas'
                },
                tooltip: {
                    pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
                },
                plotOptions: {
                    pie: {
                        allowPointSelect: true,
                        cursor: 'pointer',
                        dataLabels: {
                            enabled: true,
                            format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                            style: {
                                color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                            }
                        }
                    }
                },
                series: [{
                    name: 'Status',
                    colorByPoint: true,
                    data: [{
                        name: 'Alega Pagamento',
                        y: xx
                    }, {
                        name: 'Não Promessa',
                        y: yy,
                        sliced: true,
                        selected: true
                    }, {
                        name: 'Promessa',
                        y: zz
                    }, ]
                }]
            });
        }, 200000);

        $scope.mudaCor = function (status, valor) {
            
            if (status == "Ligações") {
                if (valor >= 8000) {

                    return '#84F075';
                }
                else if (valor >= 6000 && valor <= 7999) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }

            }
            else if (status == "Atendidas") {
                if (valor >= 700) {

                    return '#84F075';
                }
                else if (valor >= 500 && valor <= 699) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
            else if (status == "CPC") {
                if (valor >= 350) {

                    return '#84F075';
                }
                else if (valor >= 250 && valor <= 349) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
            else if (status == "Promessa") {
                if (valor >= 40) {

                    return '#84F075';
                }
                else if (valor >= 25 && valor <= 39) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
            else if (status == "Alega Pagamento") {
                if (valor >= 50) {

                    return '#84F075';
                }
                else if (valor >= 30 && valor <= 49) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
        }


        $scope.mudaCorCarinha = function (status,nome)
        {
            if (nome != 'Consolidado') {
                if (status == "Livre") {
                    return '#EAF075';
                }
                else if (status == "Ocupado") {
                    return '#F07575';
                }
                else if (status == "Desalocado") {
                    return 'silver';
                }
                else {
                    return '#F07575'
                }
            }
     
        }

        $scope.mudaCorPer = function (status, valor) {
            
            if (status == "Projeção Ligações") {
                if (valor >= 100) {

                    return '#84F075';
                }
                else if (valor >= 80 && valor <= 99) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }

            }
            else if (status == "Atendidas") {
                if (valor >= 10) {

                    return '#84F075';
                }
                else if (valor >= 5 && valor <= 10) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
            else if (status == "CPC") {
                if (valor >= 40) {

                    return '#84F075';
                }
                else if (valor >= 35 && valor <= 40) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
            else if (status == "Promessa") {
                if (valor >= 10) {

                    return '#84F075';
                }
                else if (valor >= 7 && valor <= 9) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
            else if (status == "Alega Pagamento") {
                if (valor >= 40) {

                    return '#84F075';
                }
                else if (valor >= 20 && valor <= 39) {
                    return '#EAF075';
                }
                else if (valor == 0) {
                    return '#FFFFFF';
                }
                else {
                    return '#F07575';
                }
            }
        }
    }
})(angular.module('TRESTTO'));