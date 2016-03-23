"use strict";

var app = angular.module("rikstvapp");

app.service("LocationService", ["$http", "$q", "$rootScope", function ($http, $q, $root) {

    var self = this;

    this.locationSelectorData = {
        userReal: {
            latitude: null,
            longitude: null,
            allowed: true,
            active: false
        },
        userEntered: {
            keyword: null,
            active: false
        }
    };

    var setUserLocation = function (allowed, latitude, longitude) {

        if (allowed && latitude && longitude) {
            self.locationSelectorData.userReal.latitude = latitude;
            self.locationSelectorData.userReal.longitude = longitude;
            self.locationSelectorData.userReal.allowed = true;
        } else {

            self.locationSelectorData.userReal.latitude = null;
            self.locationSelectorData.userReal.longitude = null;
            self.locationSelectorData.userReal.allowed = false;
        }
    };

    var getCurrentLocation = function () {
        navigator.geolocation.getCurrentPosition(function (data) {
            if (data && data.coords) setUserLocation(true, data.coords.latitude, data.coords.longitude);
            else setUserLocation(false);
        }, function (error) {
            setUserLocation(false);
        });
    };
}]);
