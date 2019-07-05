 var x = document.getElementById("click_poll");
             var y = document.getElementById("click_exam");
             document.getElementById("click_exam").addEventListener("click", function(){
                            document.getElementById("tab_exam").style.display="block";
                            document.getElementById("tab_poll").style.display="none";
                            
                            y.classList.add("active");
                            
                            x.classList.remove("active");
            });
            document.getElementById("click_poll").addEventListener("click", function(){
                            document.getElementById("tab_exam").style.display="none";
                            document.getElementById("tab_poll").style.display="block";
                            console.log(y.className);
                            x.classList.add("active");
                            
                            y.classList.remove("active");
                            console.log(y.className);

            });