function StudentChangeChecked(groupId) {
    var selected = new Map();     
    var checkBox = document.getElementsByName("checkboxRemove");
    for (i = 0; i < checkBox.length; i++) {
        var tr = $('#tr_' + checkBox[i].id);
        if (checkBox[i].checked == true) {            
            tr.addClass("table-danger");
            var lastName = tr.find('td[name="LastName"]').html();
            var firstName = tr.find('td[name="FirstName"]').html();
            selected.set(checkBox[i].id, lastName + " " + firstName);
        }
        else {
            tr.removeClass("table-danger");            
        }
    }    
    var btn = $("#btnMultipleRemove");
    if (selected.size > 0) {
        btn.removeClass("disabled");        
    }
    else {
        btn.addClass("disabled");        
    }

    StudentEditNames(selected);
    StudentEditUrl(selected, groupId);
}

function StudentEditNames(selected) {
    var spanNames = $('#namesStudents');
    let names = "";
    for (let n of selected.values()) {
        names += "<br>- " + n;
    }
    spanNames.html(names);
}

function StudentEditUrl(selected, groupId) {
    var submit = $('#sumbitMultipleRemove');
    let url = "";
    for (let s of selected.keys()) {
        url += "id=" + s + "&";
    }
    url = url.substring(0, url.length - 1);
    submit.attr("href", groupId + "/students/multipleDelete?" + url);
}

function StudentAllChangeChecked(groupId) {
    var checkBox = document.getElementsByName("checkboxRemove");
    for (i = 0; i < checkBox.length; i++) {       
        if (document.getElementById('generalCheckbox').checked) {
            checkBox[i].checked = true;
        }
        else {
            checkBox[i].checked = false;
        }        
    }
    StudentChangeChecked(groupId);
}