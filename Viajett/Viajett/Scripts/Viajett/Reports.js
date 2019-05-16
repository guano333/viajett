var viajett;
(function (viajett) {
    var Reports = /** @class */ (function () {
        function Reports() {
        }
        Reports.prototype.loadReports = function () {
            $.ajax({
                url: '/Home/Reports',
                type: 'GET',
                success: function (result) {
                    $("#reportcontent").html(result);
                }
            });
        };
        return Reports;
    }());
    viajett.Reports = Reports;
})(viajett || (viajett = {}));
//# sourceMappingURL=Reports.js.map