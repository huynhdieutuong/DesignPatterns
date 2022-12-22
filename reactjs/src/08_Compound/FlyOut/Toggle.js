import React, { useContext } from 'react';
import Icon from './Icon';
import { FlyOutContext } from '.';

const Toggle = () => {
  const { open, toggle } = useContext(FlyOutContext);

  return (
    <div className="flyout-btn" onClick={() => toggle(!open)}>
      <Icon />
    </div>
  );
};

export default Toggle;
