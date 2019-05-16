class viajett {
    constructor() { }

    loadTeams() {
        $.ajax({
            url: '/Home/Teams',
            type: 'GET',
            success: (result) => {
                $("#teamcontent").html(result);
            }
        });
    }

    loadTasks() {
        $.ajax({
            url: '/Home/Tasks',
            type: 'GET',
            success: (result) => {
                $("#taskcontent").html(result);
            }
        });
    }

    loadLogEntries() {
        $.ajax({
            url: '/Home/LogTime',
            type: 'GET',
            success: (result) => {
                $("#logtimecontent").html(result);
            }
        });
    }

    loadReports() {
        $.ajax({
            url: '/Home/Reports',
            type: 'GET',
            success: (result) => {
                $("#reportcontent").html(result);
            }
        });
    }
}