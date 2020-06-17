using Game_of_stones.Exceptions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TestExceptions
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]
    [TestFixture(4)]
    public class Tests
    {
        int a;
        public Tests(int q)
        {
            a = q;
        }

        string var;
        string firstvar;
        string secondvar;
        string thirdvar;
        int sum;

        [OneTimeSetUp]

        public void CreateVariationsFotTest()
        {
            switch(a)
            {
                case 1:
                    var = "������";
                    sum = 1;
                    secondvar = "������";
                    firstvar = "������";
                    thirdvar = "������";
                    break;
                case 2:
                    var = "-3";
                    sum = 0;
                    secondvar = "-3";
                    firstvar = "+1";
                    thirdvar = "+1";
                    break;
                case 3:
                    var = "+0";
                    sum = -5;
                    secondvar = "+0";
                    firstvar = "*10";
                    thirdvar = "+0";
                    break;
                case 4:
                    var = "* 8";
                    sum = -0;
                    secondvar = "* 8";
                    firstvar = "+2";
                    thirdvar = "* 8";
                    break;
            }
        }

        
        [Test]
        public void CheckTheOperatorAndOperandTest()
        {
            try
            {
                String pattern = @"([+*])+(\d+)";
                int firstNumber = 2;
                foreach (var expression in var)
                {
                    foreach (System.Text.RegularExpressions.Match r in
                    System.Text.RegularExpressions.Regex.Matches(var, pattern))
                    {
                        firstNumber = Int32.Parse(r.Groups[2].Value);                        
                    }
                }
                ClassForExceptions.CheckTheOperatorAndOperand(firstNumber);
            }
            catch (CheckTheOperatorAndOperandException ex)
            {
                Assert.AreEqual("������ ������������ �������� ��� �������. ���������� �����: ", ex.Message);
            }       
        }

        [Test]
        public void CheckFinishNumberTest()
        {
            try
            {               
                ClassForExceptions.CheckFinishNumber(sum);
            }
            catch (CheckFinishNumberException ex)
            {
                Assert.AreEqual("���������� ������ ��� ������ �� ����� ���� ������ 1���. ���������� �����: ", ex.Message);
            }
        }

        [Test]
        public void CheckVariantTest()
        {
            try
            {
                ClassForExceptions.CheckVariant(var, secondvar);
            }
            catch (CheckVariantException ex)
            {
                Assert.AreEqual("����� ������� ��� ����. ���������� �����: ", ex.Message);
            }
        }

        [Test]
        public void CheckVariantTwoTest()
        {
            try
            {
                ClassForExceptions.CheckVariant(firstvar, secondvar, thirdvar);
            }
            catch (CheckVariantException ex)
            {
                Assert.AreEqual("����� ������� ��� ����. ���������� �����: ", ex.Message);
            }
        }


    }
}