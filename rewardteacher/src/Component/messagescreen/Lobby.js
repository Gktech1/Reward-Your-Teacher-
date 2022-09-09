import { useState, useEffect } from 'react';
import axios from "axios"

const Lobby = ({ joinRoom }) => {
 const [room, setRoom] = useState('Reward Your Teacher');
 
 const [userInfo, setUserInfo] = useState({});
 const user = userInfo.firstName;
 console.log('user info.firstname', userInfo.firstName);
 console.log('user', user)

    const userData =  localStorage.getItem('user')
    const {id} = JSON.parse(userData)
    console.log(id)
  
    useEffect(() => {
     (async() => {
      const response = await axios.get(`https://localhost:7166/Student/api/v1/${id}`)
      console.log(response.data)
      setUserInfo(response.data)
     })()
    }, [])
    console.log("bug",userInfo)

    return (
    <form className='lobby'
        onSubmit={e => {
            e.preventDefault();
            joinRoom(user, room);
        }} style={{margin: '15rem auto 0 auto', width: '250px', textAlign: 'center'}}>
        <div>
            <label>
                Your username
            </label>
            <input type='text' readOnly value={user} />

        </div>

        <div>
            <label>
                 Chat with who
            </label>
            <input type='text' readOnly value={room} onChange={e => setRoom(e.target.value)} />
        </div>

        <button className='btn'  type="submit" disabled={!user || !room}>Chat</button>
    </form>)
}

export default Lobby