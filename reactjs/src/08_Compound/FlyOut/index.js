import React, { createContext, useState } from 'react';
import Item from './Item';
import List from './List';
import Toggle from './Toggle';

export const FlyOutContext = createContext();

const FlyOut = ({ children }) => {
  const [open, toggle] = useState(false);

  return (
    <div className="flyout">
      <FlyOutContext.Provider value={{ open, toggle }}>
        {children}
      </FlyOutContext.Provider>
    </div>
  );
};

FlyOut.Toggle = Toggle;
FlyOut.List = List;
FlyOut.Item = Item;

export default FlyOut;
