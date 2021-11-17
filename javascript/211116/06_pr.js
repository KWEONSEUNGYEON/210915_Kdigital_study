function MyStudent(n, a, nm)
{
    this.name = n
    this.age = a
    this.number = nm
    this.regist = function() {
        alert(this.name + '학생 등록 완료')
    }
}

window.onload = function()
{
    let my_name = document.querySelector('#name')
    let my_age = document.querySelector('#age')
    let my_num = document.querySelector('#num')

    let my_create = document.querySelector('#create')
    let my_read = document.querySelector('#read')
    let my_update = document.querySelector('#update')
    let my_delete = document.querySelector('#delete')
    let consolelog = document.querySelector('#consolelog')

    let students = []
    my_create.onclick = function() {
        for(let item of students) {
            if(item.number == my_num.value) {
                alert("중복 학생 존재")
                return
            }
        }
        let tempStudent = new MyStudent(my_name.value, my_age.value, my_num.value)
        students.push(tempStudent)
        tempStudent.regist()
        console.log(students)
    }
    my_read.onclick = function() {
        for(let item of students) {
            if(my_num.value == item.number) {
                alert(`${item.number}번 학생은 ${item.name}이며, ${item.age}살입니다.`)
                return
            }
        }
    }
    my_update.onclick = function() {
        for(let item of students) {
            if(my_num.value == item.number) {
                item.name = my_name.value
                item.age = my_age.value
            }
        }
    }
    my_delete.onclick = function() {
        for(let i = 0; i<students.length; i++) {
            if(my_num.value == students[i].number)
                students.splice(i,1)
        }
    }
    consolelog.onclick = function() {
        console.log(students)
    }
}
