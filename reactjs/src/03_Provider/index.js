import React from 'react';
import Button from './Button';
import CountContextProvider from './CountContextProvider';
import Reset from './Reset';
// import PropDrilling from './PropDrilling'
// import PropProvider from './PropProvider'

const AppProvider = () => {
  return (
    <div>
      {/* <PropDrilling /> */}
      {/* <PropProvider /> */}

      {/* Provider pattern/Context API
      - PROS: we no longer have to deal with prop-drilling.
      - CONS: Overusing the Provider pattern can result in performance issues.
      When click on Increment button in the Button component, it's not just the count re-renders, the date in Reset component re-renders as well (the Reset component also re-rendered since it consumed the useCountContext)
      => To avoid this issue, can create several providers for each separate case, to make sure the components aren't consuming providers that contain unnecessary values which may update.
      */}
      <CountContextProvider>
        <Button />
        <Reset />
      </CountContextProvider>
    </div>
  );
};

export default AppProvider;
