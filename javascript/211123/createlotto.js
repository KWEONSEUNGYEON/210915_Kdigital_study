let numbers = [] //각 회차의 로또번호 추출할 때
let mycount = -1 //몇 번째 div안에다가 로또번호 출력할지
let drwnumbers = [] //중복된 회차 찾을 때
let lotto_colors = ['yellow','blue','red','gray','green']

// 로또 생성 함수
function createLottoNum(drwnum) {
    if(isNaN(drwnum)) {
        alert("이건 숫자가 아닙니다.")
        return
    }
    if(drwnum.value == '') {
        alert('공백')
        return
    }
    for(let item of drwnumbers) {
        if(item == drwnum) {
            alert("중복된 회차")
            return
        }
    }

    for(let i=0; i<7; i++) {
        let mynum = Math.floor(Math.random()*45)+1
        if(i>0) { //하나라도 데이터 있다면 중복체크
            if(numbers.indexOf(mynum) != -1) {
                i--
                continue
            }
        }
        numbers.push(mynum)
    }
    // numbers.sort(function(a,b) { //순차정렬
    //     return a-b
    // })
    let temp = new lotto(drwnum, numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6])
    lottos.push(temp)
    numbers = [] //numbers 배열 초기화
    drwnumbers.push(drwnum) //drwnum : 회차정보 
    mycount++
}

function setBackgroundColor(num) {
    let mynum = Number(num)
    if(mynum<=10)
        return 'yellow'
    else if(mynum<=20)
        return 'blue'
    else if(mynum<=30)
        return 'red'
    else if(mynum<=40)
        return 'gray'
    else
        return 'green'
}

function setfontColor(num) {
    let mynum = Number(num)
    if(mynum>=11 && mynum<=30)
        return 'white'
    return 'black'
}

// function(){}
// () => {} 코드같음
window.onload = function() {
    let start_lotto = document.querySelector('#create_lotto')
    let drwNum = document.querySelector('#drwNum') //textbox 회차정보입력
    start_lotto.onclick = () => {
        createLottoNum(drwNum.value)
        let mylottos
        switch (mycount%3) {
            case 0:
                //id가 one인 태그의 자손들인데 클래스명이 one인 태그들
                mylottos = document.querySelectorAll('#one>.one')
                break;
            case 1:
                mylottos = document.querySelectorAll('#two>.two')
                break;
            case 2:
                mylottos = document.querySelectorAll('#three>.three')
                break;
                
            default:
                break;
        }
        mylottos[0].innerText = lottos[mycount].drwNo+"회차 :"
        mylottos[1].innerText = lottos[mycount].one
        mylottos[2].innerText = lottos[mycount].two
        mylottos[3].innerText = lottos[mycount].three
        mylottos[4].innerText = lottos[mycount].four
        mylottos[5].innerText = lottos[mycount].five
        mylottos[6].innerText = lottos[mycount].six
        mylottos[7].innerText = lottos[mycount].bns
    }

    let all_random = document.querySelector('#all_random')

    all_random.onclick = () => {
        for(let i=1; i<8; i++) {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = lotto_colors[Math.floor(Math.random()*5)]
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = lotto_colors[Math.floor(Math.random()*5)]
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = lotto_colors[Math.floor(Math.random()*5)]
        }
    }
    let case_by_case_random = document.querySelector('#case_by_case_random')

    case_by_case_random.onclick = ()=>{

        let tempcolor = lotto_colors[Math.floor(Math.random()*5)]
        for(let i =1; i<8; i++)
        {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = tempcolor
        }
        tempcolor = 
        lotto_colors[Math.floor(Math.random()*5)]

        for(let i =1; i<8; i++)
        {
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = tempcolor
        }
        tempcolor = 
        lotto_colors[Math.floor(Math.random()*5)]
        for(let i =1; i<8; i++)
        {
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = tempcolor
        }
    }
    let same_color = document.querySelector('#same_color')

    same_color.onclick = () => {
        let r = Math.floor(Math.random()*256)
        let g = Math.floor(Math.random()*256)
        let b = Math.floor(Math.random()*256)
        let tempcolor = `rgb(${r},${g},${b})`
        for(let i = 1; i<8; i++) {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = tempcolor
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = tempcolor
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = tempcolor
        }
    }
    let number_by_number = document.querySelector('#number_by_number')

    number_by_number.onclick = () => {
        for(let i=1; i<8; i++) {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#one>.one')[i].innerText)
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#two>.two')[i].innerText)
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#three>.three')[i].innerText)
        }
    }
    let black_and_white = document.querySelector('#black_and_white')

    black_and_white.onclick = () => {
        for(let i=1; i<8; i++) {
            document.querySelectorAll('#one>.one')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#one>.one')[i].innerText)
            document.querySelectorAll('#one>.one')[i].style.color = setfontColor(document.querySelectorAll('#one>.one')[i].innerText)
            document.querySelectorAll('#two>.two')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#two>.two')[i].innerText)
            document.querySelectorAll('#two>.two')[i].style.color = setfontColor(document.querySelectorAll('#two>.two')[i].innerText)
            document.querySelectorAll('#three>.three')[i].style.backgroundColor = setBackgroundColor(document.querySelectorAll('#three>.three')[i].innerText)
            document.querySelectorAll('#three>.three')[i].style.color = setfontColor(document.querySelectorAll('#three>.three')[i].innerText)
        }
    }
}