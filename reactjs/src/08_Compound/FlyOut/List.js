import React, { useContext } from 'react';
import { FlyOutContext } from '.';

const List = ({ children }) => {
  const { open } = useContext(FlyOutContext);

  return open && <ul className="flyout-list">{children}</ul>;
};

export default List;
