
const [menuBtn, hamburger, nav, menuNav, navItems] = [document.querySelector('.menu-btn'), document.querySelector('.menu-btn_burger'),
document.querySelector('.nav'), document.querySelector('.menu-nav'), document.querySelectorAll('.menu-nav_item')]

let showMenu = false;
console.log(menuBtn);
console.log(hamburger);
console.log(nav);
console.log(menuNav);
menuBtn.addEventListener('click', toggleMenu);

function toggleMenu()
{
    if(!showMenu)
    {
        hamburger.classList.add('open');
        nav.classList.add('open');
        menuNav.classList.add('open');
        navItems.forEach(item => 
          item.classList.add("open")
        );
        showMenu = true;
    }
     
    else
    {
      hamburger.classList.remove('open');
      nav.classList.remove('open');
      menuNav.classList.remove('open');
      navItems.forEach(item => 
        item.classList.remove("open")
      );
      showMenu = false;
    }

}