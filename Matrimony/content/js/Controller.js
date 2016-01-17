matrimonyapp.controller('AccountController', ['$scope', '$http', 'AngularService','$location', function ($scope, $http, AngularService,$location) {
   
    $scope.formdata = {};
    $scope.login = function () {
        
        //if ($('#txtProductName').val() == '') {
        //    setTimeout(function () {
        //        $('#txtProductName').focus();
        //        $('#txtProductName').css({
        //            "border": "1px solID red",
        //        });
        //    }, 10);
        //    return false;
        //}
        AngularService.login($scope.formdata.name, $scope.formdata.pass).success(function (response) {
                AngularService.testhome(response.results).success(function (response) {
                    $location.path("/home");
                });
            });
    };

    //clear form
    $scope.cancel = function () {
        $scope.formdata = {};
        updateID = 0;
        $('#txtProductName').css({
            "border": "",
        });
        $('#txtProductDescription').css({
            "border": "",
        });
        $("#btnSubmit").html('Submit');
    };

    //delete data
    $scope.delete1 = function (ID) {
        AngularService.Delete(ID).success(function (response) {
            AngularService.get().success(function (data) {
                $scope.Products = JSON.parse(data.d);
                $scope.formdata = {};
                updateID = 0;
            });
        });
    };
    $scope.delete = function (ID) {
        AngularService.Delete(ID).success(function (response) {
            AngularService.getlocal().success(function (response) {
                $scope.Products = response.results;
            });
        });
    };
    //edit data
    $scope.edit = function (products) {
        $scope.formdata.Name = products.Name;
        $scope.formdata.Salary = products.Salary;
        updateID = products.ID;
        $("#btnSubmit").html('Update');
    };

}]);