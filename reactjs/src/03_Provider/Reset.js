import React from 'react';
import useCountContext from './useCountContext';
import moment from 'moment';

const Reset = () => {
  const { setCount } = useCountContext();

  return (
    <div>
      <button onClick={() => setCount(0)}>Reset count</button>
      <div>Last reset: {moment().format('h:mm:ss a')}</div>
    </div>
  );
};

export default Reset;
