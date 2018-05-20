namespace FSharpx.Collections.Experimental.Tests

open Expecto

module RunTests =

    [<EntryPoint>]
    let main args =

        Tests.runTestsWithArgs defaultConfig args AltBinaryRandomAccessListTest.testAltBinaryRandomAccessList |> ignore

        Tests.runTestsWithArgs defaultConfig args BankersDequeTest.testBankersDeque |> ignore

        Tests.runTestsWithArgs defaultConfig args BatchDequeTest.testBatchDeque |> ignore

        Tests.runTestsWithArgs defaultConfig args BinaryRandomAccessListTest.testBinaryRandomAccessList |> ignore

        Tests.runTestsWithArgs defaultConfig args BinaryRoseTreeTest.testBinaryRoseTree |> ignore

        Tests.runTestsWithArgs defaultConfig args BinaryTreeZipperTest.testBinaryTreeZipper |> ignore

        Tests.runTestsWithArgs defaultConfig args BinomialHeapTest.testBinomialHeap |> ignore
        Tests.runTestsWithArgs defaultConfig args BinomialHeapTest.propertyBinomialHeap |> ignore

        //Tests.runTestsWithArgs defaultConfig args BKTreeTest.<> |> ignore

        //Tests.runTestsWithArgs defaultConfig args BlockResizeArrayTest.<> |> ignore

        Tests.runTestsWithArgs defaultConfig args BootstrappedQueueTest.testBootstrappedQueue |> ignore

        Tests.runTestsWithArgs defaultConfig args BottomUpMergeSortTest.testBottomUpMergeSort |> ignore

        Tests.runTestsWithArgs defaultConfig args DequeTest.testDeque |> ignore

        Tests.runTestsWithArgs defaultConfig args DListTest.testDList |> ignore

        //Tests.runTestsWithArgs defaultConfig args EagerRoseTreeTest.<> |> ignore

        Tests.runTestsWithArgs defaultConfig args EditDistanceTest.testEditDistance |> ignore

        Tests.runTestsWithArgs defaultConfig args FileSystemZipperTest.testFileSystemZipper |> ignore

        //Tests.runTestsWithArgs defaultConfig args FlatListTest.<> |> ignore

        Tests.runTestsWithArgs defaultConfig args HeapPriorityQueueTest.testHeapPriorityQueue |> ignore

        Tests.runTestsWithArgs defaultConfig args ImplicitQueueTest.testImplicitQueue |> ignore

        //Tests.runTestsWithArgs defaultConfig args IndexedRoseTreeTest.testIndexedRoseTree |> ignore
        //Tests.runTestsWithArgs defaultConfig args IndexedRoseTreeTest.testIndexedRoseTreeProperties |> ignore

        //Tests.runTestsWithArgs defaultConfig args IntMapTest.<> |> ignore
        //Tests.runTestsWithArgs defaultConfig args IntMapTest.<> |> ignore

        //Tests.runTestsWithArgs defaultConfig args IQueueTest.<> |> ignore

        //Tests.runTestsWithArgs defaultConfig args LeftistHeapTest.<> |> ignore

        Tests.runTestsWithArgs defaultConfig args ListZipperTest.testListZipper |> ignore

        //Tests.runTestsWithArgs defaultConfig args NonEmptyListTests.<> |> ignore

        //Tests.runTestsWithArgs defaultConfig args PairingHeapTest.<> |> ignore

        Tests.runTestsWithArgs defaultConfig args RealTimeDequeTest.testRealTimeDeque |> ignore

        Tests.runTestsWithArgs defaultConfig args RealTimeQueueTest.testRealTimeQueue |> ignore

        Tests.runTestsWithArgs defaultConfig args RingBufferTest.testRingBuffer |> ignore

        //Tests.runTestsWithArgs defaultConfig args RoseTreeTest.testRoseTree |> ignore
        //Tests.runTestsWithArgs defaultConfig args RoseTreeTest.<> |> ignore

        Tests.runTestsWithArgs defaultConfig args SkewBinaryRandomAccessListTest.testSkewBinaryRandomAccessList |> ignore

        //Tests.runTestsWithArgs defaultConfig args SkewBinomialHeapTest.testSkewBinomialHeap |> ignore

        //Tests.runTestsWithArgs defaultConfig args TimeSeriesTest.testTimeSeries |> ignore
    
        0

