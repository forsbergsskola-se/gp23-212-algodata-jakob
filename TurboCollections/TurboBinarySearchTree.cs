﻿namespace TurboCollections;

    public class Node <T>
    {
        public T Value;
        public Node <T> Left;
        public Node <T> Right;

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

public 
