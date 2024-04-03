class Sorting {
    
    public static void BubbleSort<T>(T[] arr) where T : IComparable {
        int numberOfPairs = arr.Length - 1;
        for(int i = 0; i < numberOfPairs; i++) {
            for (int j = 0; j < numberOfPairs - i; j++) {
                if (arr[j].CompareTo(arr[j + 1]) > 0) {
                    (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                }
            }
        }
    }

    public static void InsertionSort1<T>(T[] arr) where T : IComparable {
        for (int i = 1; i < arr.Length; i++) {
            for (int j = i; j > 0; j--) {
                if (arr[j].CompareTo(arr[j - 1]) < 0) {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                }
            }
        }
    }

    public static void InsertionSort2<T>(T[] arr) where T : IComparable {
        for (int i = 1; i < arr.Length; i++) {
            int temp = i;
            for (int j = temp; j > 0; j--) {
                if (arr[j].CompareTo(arr[j - 1]) < 0) {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                }
            }
        }
    }

    public static void SelectionSort<T>(T[] arr) where T : IComparable {
        int i = arr.Length - 1;
        while (i != 0) {
            T max = arr[i];
            int indexMax = i;
            for (int j = i; j >= 0; j--) {
                if (arr[j].CompareTo(max) > 0) {
                    max = arr[j];
                    indexMax = j;
                }
            }
            (arr[i], arr[indexMax]) = (arr[indexMax], arr[i]);
            i--;
        }
    }

    public static void ShellSort1<T>(T[] arr) where T : IComparable {
        for (int interval = arr.Length / 2; interval > 0 ; interval /= 2) {
            for (int i = interval; i < arr.Length; i++) {
                T temp = arr[i];
                int j;
                for (j = i; j >= interval && arr[j - interval].CompareTo(temp) > 0; j -= interval) {
                    arr[j] = arr[j - interval];
                }
                arr[j] = temp;
            }
        }
    }

    public static void ShellSort2<T>(T[] arr) where T : IComparable {
        int interval = arr.Length / 2;

        while (interval > 0) {
            for (int i = interval; i < arr.Length; i++) {
                T currentValue = arr[i];
                int position = i;

                while (position >= interval && arr[position - interval].CompareTo(currentValue) > 0) {
                    arr[position] = arr[position - interval];
                    position -= interval;
                    arr[position] = currentValue; 
                }
            }
            interval /= 2;
        }
    }

    public static void RadixSort1(int[] arr) {
        int maxElement = arr.Max();
        const int BASE = 10;

        //перебор всех разрядов, начиная с нулевого
        for (int rank = 1; maxElement / rank > 0; rank *= BASE) {
            //создание корзин
            List<int>[] baseArray = new List<int>[BASE];
            for (int i = 0; i < BASE; i++) { 
                baseArray[i] = new List<int>(); 
            } 

            //наполнение корзины
            //перебор всех элементов массива
            foreach (var item in arr) {
                //получаем цифру, чтоящую на текущем разряде в каждом числе массива 
                int digit = item / rank % BASE;
                //отправляем число в промежуточный массив в ячейку, совпадающую со значением этой цифры
                baseArray[digit].Add(item);
            }
        
            //преемещение из корзин обратно в массив
            int j = 0;
            for (int k = 0; k < BASE; k++) {
                for (int l = 0; l < baseArray[k].Count; l++) { 
                    arr[j] = baseArray[k][l]; 
                    j++; 
                }
            }
        }
    }

    public static void RadixSort2(int[] arr) {
        int maxElement = arr.Max();
        const int BASE = 10;

        int rank = 1;
        while (maxElement / rank > 0) {
            List<int>[] baseArray = new List<int>[BASE];
            for (int i = 0; i < BASE; i++) { 
                baseArray[i] = new List<int>(); 
            } 

            foreach (var item in arr) {
                int digit = item / rank % BASE;
                baseArray[digit].Add(item);
            }
        
            int j = 0;
            for (int k = 0; k < BASE; k++) {
                int l = 0;
                while (l < baseArray[k].Count) { 
                    arr[j] = baseArray[k][l]; 
                    j++; 
                    l++;
                }
            }

            rank *= BASE;
        }
    }

    private static void Merge<T>(T[] arr, int left, int mid, int right) where T : IComparable {
        int it1 = 0;
        int it2 = 0;
        T[] result = new T[right - left];

        while (left + it1 < mid && mid + it2 < right) {
            if (arr[left + it1].CompareTo(arr[mid + it2]) < 0) {
                result[it1 + it2] = arr[left + it1];
                it1 += 1;
            } else {
                result[it1 + it2] = arr[mid + it2];
                it2 += 1;
            }       
        }
        while (left + it1 < mid) {
            result[it1 + it2] = arr[left + it1];
            it1 += 1;
        }
  
        while (mid + it2 < right) {
            result[it1 + it2] = arr[mid + it2];
            it2 += 1;
        }
        for (int i = 0; i < it1 + it2; i++) {
            arr[left + i] = result[i];
        }
    }

    //function that sorts arr[l..r] using Merge()
    public static void MergeSortRecursive<T>(T[] arr, int left, int right) where T: IComparable {
        if (left + 1 >= right)
            return;
        int mid = (left + right) / 2;
        MergeSortRecursive(arr, left, mid);
        MergeSortRecursive(arr, mid, right);
        Merge(arr, left, mid, right);
    }

    //function that sorts arr[1..end] using Merge()
    public static void MergeSortIterative<T>(T[] arr) where T: IComparable {
        int n = arr.Length;
        int i = 1;
        while (i < n) {
            int left = 0;
            while (left < n - i) {
                int mid = left + i;
                int right = Math.Min(left + 2 * i, n);
                Merge(arr, left, mid, right);
                left += 2 * i;
            }
            i *= 2;
        }
    }

    //function for quick sort
    public static int Partition<T>(T[] arr, int left, int right) where T: IComparable {
		T partition = arr[(left + right) / 2];
		int i = left;
		int j = right - 1;
		while (i <= j) {
            while (arr[i].CompareTo(partition) < 0) {
                i++;
            }
            while (arr[j].CompareTo(partition) > 0) {
                j--;
            }
            if (i >= j) {
                return j;    
            }   
            (arr[i], arr[j]) = (arr[j], arr[i]);
            i++;
            j--;
        }
        return j;
    }

    public static void QuickSort<T>(T[] arr, int left, int right) where T: IComparable {
        if (left < right) {
            int partition = Partition(arr, left, right);
            QuickSort(arr, left, partition);
            QuickSort(arr, partition + 1, right);
        }
    }
}

