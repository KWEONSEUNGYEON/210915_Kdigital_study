$(
    function()
    {
        const sounds = $('audio')
        const pads = $(".pads div")
        const visual = $('.visual')
        const title = $('.title')
        const colors = ['coral','cornflowerblue', 'seagreen','greenyellow','paleturquoise','plum']

        // 음악 재생 끝났을 때 이벤트
        //js의 forEach
        sounds.each(function(index, soundFile)
        {
            soundFile.onended = function() {
                visual.text('')
                title.text('')
            }
        })

        pads.each(function(index, pad)
        {
            $(pad).on('click', function(){
                sounds.each(function(index, soundFile) {
                    soundFile.pause()
                })
                // 내가 클릭한 부분의 사운드
                if(sounds[index]) {
                    sounds[index].currentTime = 0
                    sounds[index].play()
                    // audio태그의 src속성의 문자열을 sound/로 짜름
                    const strArray = sounds[index].src.split("sound/")
                    title.text(strArray[1]) //1.mp3 등의 제목으로 찍힘 
                }
                // index는 
                createBubbles(index)
            })
        })
        const createBubbles = function(index)
        {
            visual.text('')
            const bubble = $('<div></div')
            visual.append(bubble) //visual에 bubble삽입
            bubble.css('background', colors[index]).css('top','300px').css('animation', 'animation 2000ms linear infinite both')
        }
    }
)