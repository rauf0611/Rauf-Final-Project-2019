/* --------------HEADER */
header{
    width: 100%;
    height: 830px;
    background-image: url('http://monde.elitelayers.com/html/images/main-slider/image-1.jpg');
    background-size: cover;

}
.navbar{
    background: transparent !important;
}
.dropdown{
    padding-right: 5px;
}

.nav-link{
    color: white !important;
    font-family: 'Nunito', sans-serif;    
    font-weight: bold;
    text-transform: uppercase;
    position: relative;
    display: block;
    padding: 10px 0px;
    font-size: 11.5px;
    /* line-height: 30px; */
    font-weight: 700;
    opacity: 1;
    letter-spacing: 1px;
    text-transform: uppercase;
    transition: all 500ms ease;
    -moz-transition: all 500ms ease;
    -webkit-transition: all 500ms ease;    
    
}

.dropdown-menu {
    position: absolute;
    top: 100%;
    left: 0;
    z-index: 1000;
    display: none;
    float: left;
    min-width: 10rem;
    padding: .5rem 0;
    margin: .125rem 0 0;
    font-size: 1rem;
    color: #212529;
    text-align: left;
    list-style: none;
    background-clip: padding-box;
    border: 1px solid rgba(0,0,0,.15);
    border-radius: .25rem;
    background-color: rgb(87, 25, 25);
}
.dropdown-item {
    display: block;
    width: 100%;
    padding: .25rem 1.5rem;
    clear: both;
    font-weight: 400;
    color: #212529;
    text-align: inherit;
    white-space: nowrap;
    border-top: 1px solid brown;
    color: #fff;
    transition:all 0.3s linear ; 


}
.dropdown-item:hover{
    background-color: white ;
}
.dropdown:hover .dropdown-menu {
    display: block;
    margin-top: 0; 
}
.nav-item i{
    font-size: 1.5em;
}


.dropdown-toggle::after{
    display: none;
}

.header-text p{
    font-family: 'Montserrat', sans-serif;
    text-transform: uppercase;
    color: #ffffff;
    letter-spacing: 4px !important;
    margin-top: 240px;
    
}

.header-text h2 {
    font-size: 75px;
    color: #ffffff;
    font-weight: 700;
    line-height: 1.3em;
    letter-spacing: 1px;
    text-transform: uppercase;
    
}


.header-text h6{
    font-family: 'Conv_georgia';
    text-transform: uppercase;
    color: #ffffff;
    margin-top: 20px;
    font-size: 12px;
    letter-spacing: 2px;
}
/* HEADER-------------- */