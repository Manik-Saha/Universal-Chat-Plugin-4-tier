app.controller("login",function($scope,ajax,$location){
    $scope.login = function(u){
        ajax.post(API_ROOT+"api/Login",u,
        function(response){
            if(response.data != null){
            $location.path("/");
            }
        },
        function(err){
            $scope.error = "Invalid Username or Password";
        });
    };
});