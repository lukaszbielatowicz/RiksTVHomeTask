"use strict";

var required = [
    "ngRoute", 
    "ngResource", 
    "ngAnimate",
    "ngSanitize",
    "ui.select"
];

var appRoot = angular.module("rikstvapp", required);

appRoot.config([
    "$routeProvider", "$httpProvider", "uiSelectConfig", function($routeProvider, $httpProvider, uiSelectConfig) {

        $httpProvider.interceptors.push(function() {
            return {
                request: function(config) {
                    if (/^api:/.test(config.url))
                        config.url = config.url.replace(/^api:/, location.origin + "/api/"); // move to config file
                    return config;
                }
            };
        });

        $routeProvider
            .when("/", { templateUrl: "/view/mainpage", controller: "MainPageController" })
            .when("/place/:id", { templateUrl: "/view/placedetails", controller: "PlaceDetailsController" })
            .otherwise({ redirectTo: "/" });

        uiSelectConfig.theme = "select2";
        uiSelectConfig.resetSearchInput = true;
    }
]);

appRoot.run(["$http", function($http) {
    $http.defaults.useXDomain = true;
    
    $http.query = function (url, data, conf) {
        return $http(angular.extend(conf || {}, {
            method: "get",
            url: url,
            params: data || {}
        }));
    };
}]);
    