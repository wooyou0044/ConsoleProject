using System;
namespace Day6Program
{
    internal class Program
    {
        // 열거형, 구조체는 대문자로 작성 권장
        // 열거형, 구조체도 변수를 만들어야 의미가 생김

        // 나만의 열거형 만들고 싶다.
        // enum [열거형이름]
        // {
        //     열거형요소1, 요소, 요소
        // }
        enum BurgerKingMenu
        {
            // 원래는 영어만 작성 권장
            불고기와퍼, 몬스터와퍼, 치즈버거, 치킨버거, 통새우와퍼, 치킨너겟
        }

        enum McdonardMenu
        {
            치즈버거, 빅맥, 상하이버거, 맥크리스피, 치킨버거
        }

        enum SelectMap
        {
            // 숫자를 대입 안 하면 0부터 시작, 몇 번째로 할건지 지정 가능
            // null은 못 넣음
           //마을 = 1, 사냥터, 상점, 센터 = 10, 광장
           디폴트, 마을, 사냥터, 상점, 센터 = 10, 광장
        }

        // 구조체
        //struct[원하는 구조체명]
        //{
        //    [자료형][변수명];
        //    [자료형][변수명];
        //    [자료형][변수명];
        //}

        // 설계도 만들기
        struct Car // 자동차라는 자료형 하나 만들었고, 이름은 Car
        {
            // 접근 지정자 : public, private (미래에 protected)
            public float maxSpeed; // 멤버변수, 혹은 필드, 구성요소
            public string makeCar;
            // public / private을 안 쓰면 자동으로 private으로 쓰임
            //private int carNumber;
            int carNumber; // 건드리지 않았으면 하는 변수들 숨김
        }

        public enum ItemType
        {
            weapon, armour, usable
        }

        public struct Item
        {
            public string name;
            public int price;
            public ItemType itemType;
            //string itemT;
            float dropRate;
            public int[] useRate;
        }

        static void Main(string[] args)
        {
            #region 복습
            // 함수
            /*
             * 실행 후 반환하는 것도 없고, 준비물도 필요 없는 경우
             * 실행 후 반환하는 것은 없고, 준비물이 필요한 경우
             * 실행 후 반환이 있고, 준비물이 필요 없는 경우
             * 실행 후 반환이 있고, 준비물도 필요한 경우
             */

            // [반환 자료형] [함수 이름] [매개 변수, 매개변수, 매개변수]
            // [ref int]
            // [int [,]]
            // {
            //
            //
            // }

            //// 4개의 정수를 인자로 받아 가장 큰 수를 출력하는 함수 제작
            //// 가장 큰 수를 출력
            //GetMax(5, 4, 7, 8);

            //// 5개의 float형을 인자로 받아, 그 중 가장 큰 두 수의 합을 실수형으로 반환하는 함수 제작
            //GetMaxTwoSum(1.1f, 2.2f, 3.3f, 4.4f, 5.5f);

            //// 2개의 정수를 입력 받고, 두 수의 차이가 100 미만일 경우 참, 아니면 거짓 반환하는 함수
            //// 2개의 정수를 인자값으로 받고, 두 수의 차이가 100 미만일 경우 참, 아니면 거짓 반환하는 함수
            //isDiff100(45, 159);

            //// 배열에서 가장 큰 수 찾아서 반환하는 함수 제작
            //int[] inputArr = new int[4] { 1, 2, 4, 3 };
            //FindMax(inputArr);

            //// 순서대로 나열, 난리 났고, 무작위고,
            //// 버블 정렬
            //int[] arr = { 1, 6, 11, 4, 15, 7, 7, 9, 18, 12 };

            //// 반환은 딱히 없고, 배열이 주어지면 이를 정렬하는 기능
            //BubbleSort(arr);
            #endregion

            #region 열거형

            // 열거형(enumerator) : 나열하다

            int a; // 정수
            float b; // 실수
            BurgerKingMenu SongpaBK; // 열거형에는 저희가 담으라고 지시하는 것만 담을 수 있음
                                     // BurgerKingMenu 안에 있는 것만 대입 가능
            SongpaBK = BurgerKingMenu.치킨너겟;

            McdonardMenu SongPaMc;
            //SongPaMc = McdonardMenu.상하이버거;
            // int형에는 정수만 넣고 float형에는 실수만 넣을 수 있는 것처럼 다른 거 못 집어넣음
            //SongPaMc = BurgerKingMenu.몬스터와퍼;

            Console.WriteLine("이동 할 장소를 설정해주세요");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 사냥터");
            Console.WriteLine("3. 상점");

            SelectMap selectedMap = SelectMap.디폴트;

            // 형변환 실수에서 숫자로 바꾸듯
            int myNum = (int)2.5;

            // 숫자도 열거형식으로 바꿀 수 있음
            selectedMap = (SelectMap)1;
            // 7을 넣으면 숫자 7만 나옴
            //selectedMap = (selectMap)7;

            Console.WriteLine(selectedMap); // 마을
            Console.WriteLine((int)selectedMap); // 1

            // Enum.IsDefined //
            //Enum.IsDefined(typeof(SelectMap), 7);
            // 7이 정의가 되어 있으면 True가 나오고 정의가 안 되어 있으면 False가 나옴
            Console.WriteLine(Enum.IsDefined(typeof(SelectMap), 7)); // False가 나옴

            var temp = selectedMap.ToString();
            Console.WriteLine(temp);

            // 영어와 한글 둘 다 검색 가능
            Enum.TryParse(Console.ReadLine(), out selectedMap);
            Console.Clear(); // 화면을 지워줍니다.

            switch (selectedMap)
            {
                case SelectMap.마을:
                    Console.WriteLine("마을로 이동합니다");
                    break;
                case SelectMap.사냥터:
                    Console.WriteLine("사냥터로 이동합니다");
                    break;
                case SelectMap.상점:
                    Console.WriteLine("상점으로 이동합니다");
                    break;
                case SelectMap.센터:
                    Console.WriteLine("센터로 이동합니다");
                    break;
                case SelectMap.광장:
                    Console.WriteLine("광장으로 이동합니다");
                    break;
                default:
                    Console.WriteLine("1,2,3 어느것도 아니에요");
                    break;
            }

            // 열거형을 가져다가 쓴 것과 동일 (F12로 확인 가능)
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("                              ");
            Console.ResetColor();

            Console.WriteLine();

            // 열거형 인자로 넘기는 방법
            ChangeColorPrintAndReset("붉은색", ConsoleColor.Red);
            ChangeColorPrintAndReset("푸른색", ConsoleColor.Blue);
            Console.WriteLine("그 사이 3초 그 짧은 시간");
            #endregion

            #region 구조체

            // 구조체(Structure) : 구조물, 인위적으로 만들어진 물체
            //float maxSpeedCar1 = 220.4f;
            //string makeCar1 = "Hyundai";
            //int carNumber1 = 322;

            //float maxSpeedCar2 = 260.54f;
            //string makeCar2 = "Audi";
            //int carNumber2 = 2248;

            //float maxSpeedCar3 = 310.8f;
            //string makeCar3 = "Lamborghini";
            //int carNumber3 = 351;

            //Console.WriteLine(maxSpeedCar1);
            //Console.WriteLine(makeCar1);
            //Console.WriteLine(carNumber1);

            //Console.WriteLine(maxSpeedCar2);
            //Console.WriteLine(makeCar2);
            //Console.WriteLine(carNumber2);

            //Console.WriteLine(maxSpeedCar3);
            //Console.WriteLine(makeCar3);
            //Console.WriteLine(carNumber3);

            // 접근 지정자


            //[자료형] [변수 이름]
            Car firstCar;
            firstCar.maxSpeed = 15.0f;

            Car secondCar;
            secondCar.makeCar = "Kia";

            Console.WriteLine(firstCar.maxSpeed);

            Item firstItem;
            firstItem.price = 122;
            firstItem.itemType = ItemType.weapon;

            int[] intArr = new int[4]; // 정수형 4개를 담을 배열

            string[] strArr = new string[4];

            Item[] inventory = new Item[4]; //아이템 4개를 담을 배열
            //inventory[0].name = "황갑충";
            //Console.WriteLine(inventory[0].name);
            inventory[0].name = "공허의 지팡이";
            inventory[0].price = 123;
            inventory[0].useRate = new int[4];
            inventory[0].useRate[0] = 1;
            Console.WriteLine(inventory[0].useRate[0]);
            #endregion
        }

        static void GetMax(int a, int b, int c, int d)
        {
            int max = 0; // 임시로 변수를 만드는데, 시작과 동시에 a와 동일시

            if (b > max) // 만약 b가 현재 최대값보다(a보다) 크다면
            {
                max = b; // b가 최대보다 크면 b를 최대값이라고 대입
            }

            if (c > max) // 만약 c가 현재 최대값보다(a보다) 크다면
            {
                max = c; // c가 최대보다 크면 c를 최대값이라고 대입
            }

            if (d > max) // 만약 d가 현재 최대값보다(a보다) 크다면
            {
                max = d; // d가 최대보다 크면 d를 최대값이라고 대입
            }

            Console.WriteLine("최대값은 " + max + "입니다.");
        }

        static float GetMaxTwoSum(float a, float b, float c, float d, float e)
        {
            float max1 = float.MinValue; // 가장 큰 수 담을 것
            float max2 = float.MinValue; // 두번쨰로 큰 수 담을 것

            float[] numbers = { a, b, c, d, e };

            foreach (float num in numbers)
            {
                if (num > max1)
                {
                    max2 = max1; // 기존 최대값을 두번째 큰 값으로 갱신
                    max1 = num; // 새 최대값 갱신
                }
                else if (num > max2)
                {
                    max2 = num;
                }
            }

            return max1 + max2;
        }

        static bool isDiff100(int num1, int num2)
        {
            int difference = (num1 - num2);

            if(difference < 0)
            {
                difference = -difference;
            }

            return difference < 100;
        }

        static int FindMax(int[] arr)
        {
            int max = arr[0]; // 최대를 기억할 변수 하나 제작, 0번 인덱스 값 저장

            foreach(int num in arr) // 배열 요소 하나씩 집어 넣을거임
            {
                if(num > max)
                {
                    max = num;
                }
            }

            return max;
        }

        // 정수 인자값이 양수면 "양수" 반환, 음수면 "음수" 반환, 아니면 "0" 출력, 반환값은 string형
        static string CheckNumber(int num)
        {
            if(num > 0)
            {
                // 앞에 return이 실행되면 뒤에 것은 모조리 무시하고 마지막 }로 이동
                return "양수";
            }
            
            if(num < 0)
            {
                return "음수";
            }

            // 컴퓨터가 생각하기에 대괄호 안에 return이 있을 거라는 보장이 없기 때문에 여기에 return이 없으면 오류 발생
            return "0";
        }

        // 반환은 딱히 없고, 배열이 주어지면 이를 정렬하는 기능
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length; // 배열의 길이를 기억할 거임

            Console.WriteLine("아래 것 실행 전");

            //foreach(var elements in arr)
            //{
            //    Console.Write(elements + " ");
            //}
            PrintArray(arr);
            Console.WriteLine();

            // 처음부터 끝까지 앞 뒤로 비교하면서 나아가는 것
            //for (int j = 0; j < n - 1; j++)
            //{
            //    if (arr[j] > arr[j+1])
            //    {
            //        int temp = arr[j];
            //        arr[j] = arr[j + 1];
            //        arr[j + 1] = temp;
            //    }
            //}

            // 위에 것을 한 번 반복해야 최종적으로 정렬 가능
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("아래 것 실행 이후");
            //foreach (var elements in arr)
            //{
            //    Console.Write(elements + " ");
            //}
            PrintArray(arr);
        }

        static void PrintArray(int[] toPrint)
        {
            foreach (var elements in toPrint)
            {
                Console.Write(elements + " ");
            }
        }

        // 인자값으로 출력하고자 하는 문자열과 색을 주면 그걸로 바꿔서 출력하는 기능
        static void ChangeColorPrintAndReset(string inputString, ConsoleColor inputColor)
        {
            //Console.ForegroundColor = inputColor;
            Console.BackgroundColor = inputColor;
            Console.WriteLine(inputString);
            Console.ResetColor();
        }
    }
}
