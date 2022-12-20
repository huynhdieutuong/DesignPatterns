const Fahrenheit = ({ value = 0 }) => {
  return <div className="temp">{(value * 9) / 5 + 32}°F</div>;
};

export default Fahrenheit;
