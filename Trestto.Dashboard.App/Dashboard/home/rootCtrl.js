/// <reference path="rootCtrl.js" />
(function (app) {
    app.controller('rootCtrl', rootCtrl);

    rootCtrl.$inject = ["$scope", "$location"];

    function rootCtrl($scope, $location) {
        console.log('foifoifofof');
        $scope.FODASEE = 'IFUDEI';
    }
})(angular.module('TRESTTO'));