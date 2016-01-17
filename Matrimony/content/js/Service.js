matrimonyapp.factory('AngularService', ['$http', function ($http) {
    return {
        //load data service
        createHeader: function () {
            //btoa is a built in browser cmd for encode Base64
            return { 'Authorization': "Basic " + btoa("test:testpw") };
        },

        testhome: function (token) {
            return $http({
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8',
                    'Token': token
                },
                url: 'http://localhost:4342/User.svc/home',
                data: {}
            });
        },

        getlocal: function () {
            return $http({
                headers: { 'Authorization': "Basic " + btoa("test:testpw") },
                method: 'GET',
                dataType: "json",
                url: 'http://localhost:24706/MyService.svc/getitems',
            });
        },
        get: function () {
            return $http({
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8'
                },
                url: 'http://www.wcfdemo.somee.com/ProductService.svc/LoadAllProductDetail',
                data: {}
            });
        },

        //add data service
        login: function (user, pass) {
            var userobj = {
                username: user,
                password: pass
            };
            return $http({
                headers: {
                    'Content-Type': 'application/json; charset=utf-8'
                },
                url: 'http://localhost:4342/Account.svc/login',
                //contentType: "application/json",
                dataType: "json",
                method: 'POST',
                data: { userobj: JSON.stringify(userobj) }
            });
        },

        //delete data service
        Delete: function (productId) {
            return $http({
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8'
                },
                url: 'http://localhost:24706/MyService.svc/deleteemp',
                data: productId
            });
        },

        //update data service
        Update: function (productId, productName, productDescription) {
            var objemp = {
                ID: productId,
                Name: productName,
                Salary: productDescription
            };
            return $http({
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json; charset=utf-8'
                },
                url: 'http://localhost:24706/MyService.svc/Updateemp',
                data: { objemp: JSON.stringify(objemp) }
            });
        }

    };
}]);