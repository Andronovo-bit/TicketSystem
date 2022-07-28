import React, { useState } from "react";
//import { myFunction } from 'react-seat-picker';
const Seatmap = require('react-seatmap')

const ChooseSeats = () => {

  const rows = [
    {
      number: 1,
      isReserved: false
    }
  ]

  return (
    <>
      <div className="App">
        <h1>Seat Picker</h1>
      </div>
      <div>
        <h1>Seat Picker</h1>
        <Seatmap rows={rows} maxReservableSeats={3} alpha />,
      </div>
    </>
  )
}

export default ChooseSeats