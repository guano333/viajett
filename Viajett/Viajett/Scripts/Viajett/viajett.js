var viajett = /** @class */ (function () {
    function viajett() {
    }
    viajett.prototype.loadTeams = function () {
        $.ajax({
            url: '/Home/Teams',
            type: 'GET',
            success: function (result) {
                $("#teamcontent").html(result);
            }
        });
    };
    viajett.prototype.loadTasks = function () {
        $.ajax({
            url: '/Home/Tasks',
            type: 'GET',
            success: function (result) {
                $("#taskcontent").html(result);
            }
        });
    };
    viajett.prototype.loadLogEntries = function () {
        $.ajax({
            url: '/Home/LogTime',
            type: 'GET',
            success: function (result) {
                $("#logtimecontent").html(result);
            }
        });
    };
    viajett.prototype.loadReports = function () {
        $.ajax({
            url: '/Home/Reports',
            type: 'GET',
            success: function (result) {
                $("#reportcontent").html(result);
            }
        });
    };
    return viajett;
}());
//# sourceMappingURL=viajett.js.map