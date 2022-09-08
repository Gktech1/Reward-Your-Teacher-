import { useState } from 'react';

const Lobby = ({ joinRoom }) => {
    const [user, setUser] = useState('');
    const [room, setRoom] = useState('');
    //const username = localstroage.getItem
    //const roomId = localstroage.getItem

    return <form className='lobby'
        onSubmit={e => {
            e.preventDefault();
            joinRoom(user, room);
        }} style={{margin: '15rem auto 0 auto', width: '250px', textAlign: 'center'}}>
        <div>
            <label for=''>
                Name here
            </label>
            <input type='text' value={user} onChange={e => setUser(e.target.value)} />

        </div>

        <div>
            <label>
                 Chat 
            </label>
            <input type='text' value={room} onChange={e => setRoom(e.target.value)} />
        </div>

        <button className='btn'  type="submit" disabled={!user || !room}>Join</button>
    </form>
}

export default Lobby