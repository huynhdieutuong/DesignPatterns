import { useState } from 'react';

const Input = ({ renderProps }) => {
  const [value, setValue] = useState(0);

  return (
    <>
      <input
        type="text"
        value={value}
        onChange={(e) => setValue(Number(e.target.value))}
        placeholder="Temp in °C"
      />
      {renderProps(value)}
    </>
  );
};

export default Input;
