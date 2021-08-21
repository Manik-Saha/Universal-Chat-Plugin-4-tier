app.controller("createOrganization",function($scope,ajax,$location){
    $scope.createOrganization = function(o){
        ajax.post(API_ROOT+"api/Organization/Add",o,
        function(response){
            $scope.msg = "Registered Successfully";
            $location.path("/Organization/All");
        },
        function(err){

        });
    };
});