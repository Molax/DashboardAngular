(function (app) {
    app.directive('resizable', function () {

        return {
            restrict: 'A',
            scope: {
                callback: '&onResize'
            },
            link: function postLink(scope, elem, attrs) {
                elem.resizable();
                elem.on('resize', function (evt, ui) {
                    scope.$apply(function () {
                        if (scope.callback) {
                            scope.callback({ $evt: evt, $ui: ui });
                        }
                    })
                });
            }
        };
    });

})(angular.module("TRESTTO"));