﻿// Accord Machine Learning Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2017
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.MachineLearning.Performance
{
    using System;
    using Accord.Compat;

    /// <summary>
    ///   Information class to store the training and validation errors of a model. 
    /// </summary>
    /// 
    [Serializable]
    public class SplitResult<TModel, TInput, TOutput> : TrainValSplit<SetResult<TModel>>,
        ITransform<TInput, TOutput>
        where TModel : ITransform<TInput, TOutput>
    {

        /// <summary>
        ///   Gets the total number of samples contained in the subset used to teach the <see cref="Model"/>.
        /// </summary>
        /// 
        public int NumberOfSamples
        {
            get { return Training.NumberOfSamples + Validation.NumberOfSamples; }
        }

        /// <summary>
        ///   Gets the average number of samples between the <see cref="TrainValSplit{T}.Training"/>
        ///   and <see cref="TrainValSplit{T}.Validation"/> sets.
        /// </summary>
        /// 
        /// <value>The average number of samples.</value>
        /// 
        public double AverageNumberOfSamples
        {
            get { return (Training.NumberOfSamples + Validation.NumberOfSamples) / 2.0; }
        }

        /// <summary>
        ///   Gets the model.
        /// </summary>
        /// 
        public TModel Model { get; private set; }

        /// <summary>
        ///   Gets or sets the index of this split.
        /// </summary>
        /// 
        /// <value>The data set split index.</value>
        /// 
        public int Index { get; set; }

        /// <summary>
        ///   Gets or sets a tag for user-defined information.
        /// </summary>
        ///
        public object Tag { get; set; }

        /// <summary>
        ///   Initializes a new instance of the <see cref="SplitResult{TModel, TInput, TOutput}"/> class.
        /// </summary>
        /// 
        /// <param name="model">The model.</param>
        /// <param name="index">The index of this subset in relation to the entire set, if applicable.</param>
        /// 
        public SplitResult(TModel model, int index)
        {
            this.Model = model;
            this.Index = index;
        }




        /// <summary>
        /// Gets or sets the number of inputs accepted by the model.
        /// </summary>
        /// <value>The number of inputs.</value>
        public int NumberOfInputs
        {
            get { return Model.NumberOfInputs; }
            set { Model.NumberOfOutputs = value; }
        }

        /// <summary>
        /// Gets or sets the number of outputs generated by the model.
        /// </summary>
        /// <value>The number of outputs.</value>
        public int NumberOfOutputs
        {
            get { return Model.NumberOfOutputs; }
            set { Model.NumberOfOutputs = value; }
        }

        /// <summary>
        /// Applies the transformation to an input, producing an associated output.
        /// </summary>
        /// <param name="input">The input data to which the transformation should be applied.</param>
        /// <returns>The output generated by applying this transformation to the given input.</returns>
        public TOutput Transform(TInput input)
        {
            return Model.Transform(input);
        }

        /// <summary>
        /// Applies the transformation to a set of input vectors,
        /// producing an associated set of output vectors.
        /// </summary>
        /// <param name="input">The input data to which
        /// the transformation should be applied.</param>
        /// <returns>The output generated by applying this
        /// transformation to the given input.</returns>
        public TOutput[] Transform(TInput[] input)
        {
            return Model.Transform(input);
        }

        /// <summary>
        /// Applies the transformation to a set of input vectors,
        /// producing an associated set of output vectors.
        /// </summary>
        /// <param name="input">The input data to which
        /// the transformation should be applied.</param>
        /// <param name="result">The location to where to store the
        /// result of this transformation.</param>
        /// <returns>The output generated by applying this
        /// transformation to the given input.</returns>
        public TOutput[] Transform(TInput[] input, TOutput[] result)
        {
            return Model.Transform(input, result);
        }
    }
}
