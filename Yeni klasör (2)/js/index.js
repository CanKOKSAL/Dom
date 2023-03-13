const login=document.querySelectorAll("#Login")



login.addEventListener("click", (e) =>{
    e.preventDefault();
    const usarname = document.querySelector("#Usarnameid").value;
    const password = document.querySelector("#Passwordid").value;
    if (value>0) {
      const first = document.querySelector("#First");
      const second=document.querySelectorAll("#Second")
      first.style.display = "none";
      second.style.display = "block";
    } else {
      alert("Your name or password must be wrong please correct them");
    }
});

