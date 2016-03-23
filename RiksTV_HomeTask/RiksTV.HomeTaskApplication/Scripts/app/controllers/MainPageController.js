"use strict";

angular.module("rikstvapp").controller("MainPageController", ["$scope", "$route", "$routeParams", "$http", function ($scope, $route, $routeParams, $http) {
    $scope.placeType = {
        selected: {},
        places: []
    }

    $scope.selectPlace = function(a) {
        console.log(a);
    };

    $http.query("api:/places/getsearchtypes", {}).success(function (data) {
        $scope.placeType.places.length = 0;
        for (var i = 0; i < data.length; i++) {
            $scope.placeType.places.push(data[i]);
        }
    });
}]);
