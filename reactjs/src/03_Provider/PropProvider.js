import React, { createContext, useContext } from 'react';

const DataContext = createContext();

const PropProvider = () => {
  const data = {
    listItem: 'PropProvider',
    title: 'Title',
    text: 'Text',
  };

  return (
    <DataContext.Provider value={{ data }}>
      <SideBar />
      <Content />
    </DataContext.Provider>
  );
};

const SideBar = () => <List />;
const List = () => <ListItem />;
const ListItem = () => {
  const { data } = useContext(DataContext);
  return <span>{data.listItem}</span>;
};

const Content = () => (
  <div>
    <Header />
    <Block />
  </div>
);
const Header = () => {
  const { data } = useContext(DataContext);
  return <div>{data.title}</div>;
};
const Block = () => <Text />;
const Text = () => {
  const { data } = useContext(DataContext);
  return <div>{data.text}</div>;
};

export default PropProvider;
