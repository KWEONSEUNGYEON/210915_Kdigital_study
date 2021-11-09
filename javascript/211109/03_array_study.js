let aa = [1,2,'삼', 4]
aa.push('오5') //맨 끝에 값 추가 방법 1
for(let item of aa)
    console.log(item)

aa[aa.length] = 6 //맨 끝에 값 추가 방법 2
for(let item of aa)
    console.log(item)

aa[10] = 10
console.log(aa) //[6] ~ [9]까지 empty가 들어감
console.log(aa.length)

//특정 요소 제거
aa.splice(0,1) //가장 첫번째꺼 하나를 지움
console.log("-----0번째꺼 지움-----")
for(let item of aa)
    console.log(item)

aa.splice(1,3) //두번째([1]번째)부터 시작해서 3개 지움
console.log("-----3개 지운 뒤-----")
for(let item of aa)
    console.log(item)

//index(위치) 모르지만 특정 위치에 있는 값 지우고 싶을 때
//indexOf : 특정 값의 인덱스값을 구함
const myindex = aa.indexOf(6)
console.log("6의 위치"+myindex)
aa.splice(myindex,1)
console.log("-----6을 지운 뒤-----")
for(let item of aa)
    console.log(item)

//특정 위치에 값 추가하기
//
aa.splice(2,0,1000) //[2]번째 인덱스에 1000추가
console.log("-----[2]번째에 1000추가-----")
for(let item of aa)
    console.log(item)
