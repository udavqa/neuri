using static System.Math;

namespace neiro.NeuroNet
{
    class Neuron
    {
        //поля
        private NeuronType type; //тип нейрона
        private double[] weights; //его веса
        private double[] inputs; //его входы
        private double output; //его выход
        private double derivative; //производная

        //константы для функции активации
        private double a = 0.01d;

        //свойства
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => inputs; set => inputs = value; }
        public double Output { get => output; }
        public double Derivative { get => derivative; }

        //конструктор
        public Neuron(double[] memoryWeights, NeuronType typeNeuron)
        {
            type = typeNeuron;
            weights = memoryWeights;
        }

        //метод активации нейрона
        public void Activator(double[] i)
        {
            inputs = i; //передача вектора входного сигнала в массив входных данных нейрона
            double sum = weights[0]; //аффиное преобразование через смещение(нулевой вес - порог)
            for (int j = 0; j < inputs.Length; j++) //цикл вычисления индуцированного поля нейрона
            {
                sum += inputs[j] * weights[j + 1]; //линейные преобразования входных сигналов
            }

            switch (type)
            {
                case NeuronType.Hidden:  //для нейронов скрытого слоя
                    output = LeakyReLU(sum);
                    derivative = LeakyReLU_Derivativator(sum);
                    break;

                case NeuronType.Output: //для нейронов выходного слоя
                    output = Exp(sum);
                    break;
    
            }
        }

        //функция активации нейрона
        private double LeakyReLU(double sum)
        {
            return 0;
        }

        private double LeakyReLU_Derivativator(double sum)
        {
            return 0;
        }









    }
}
