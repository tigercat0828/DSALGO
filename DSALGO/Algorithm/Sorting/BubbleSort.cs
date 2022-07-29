﻿namespace DSALGO.Algorithm {
    public static class BubbleSort {
        /*
         * https://afteracademy.com/blog/comparison-of-sorting-algorithms   
        Time Complexity : O(n^2)
        stable : yes
        in-place : yes
         */
        public static void Run(int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                for (int j = 0; j < array.Length - i - 1; j++) {
                    if (array[j] > array[j + 1]) {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

    }
}
