import styled from 'styled-components';

const MessageContainer = styled.div`
h1{
    text-align: center; 
    font-size: 16px;
    font-weight: 600; 
    line-height: 19px;
    font-family: Inter; 
    color: #03435F;
    padding-bottom: 10px;
  
}
`;

const MessageContainerBody = styled.div`
    display:flex;
    height: 70px;
    color: #D9D9D9; 
    align-items: center;
    margin-top: 3rem;
    padding: 1rem;
    
    .image-div{
        margin-top: 18px;
        height: 100%;
        flex:1rem;
    }
    
    .body {
        border: 1px solid grey;
        background-color:  #979797;
        height: 70%;
        margin-left: 0.5%;
        width: 100%;
    }
`;




const MessageContainerBodyRight = styled.div`
    display:flex;
    height: 70px;
    color: #D9D9D9; 
    align-items: center;
    margin-top: 3rem;
    padding: 1rem;
    
    .image-div{
        margin-top: 18px;
        height: 100%;
        flex:1rem;
    }
    
    .body {
        border: 1px solid grey;
        background-color: #55A630;
        height: 70%;
        margin-left: 0.5%;
        width: 100%;
    }
`;

const MessageTextBox = styled.div`
    display: flex;
    padding: 1rem;
    margin-top: 20rem;
    margin-Bottom: -30px;
`;

const Send = styled.div`
   
    height: 26px;
    padding: 0.9rem;
    margin-left: 1rem;
    border: 1px solid grey;
    border-radius: 10px;
    margin-buttom: 1rem;
`;



export {MessageContainer, MessageContainerBody, MessageContainerBodyRight, MessageTextBox, Send}