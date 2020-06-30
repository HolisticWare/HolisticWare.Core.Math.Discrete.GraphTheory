﻿// /*
//    Copyright (c) 2017-12
//
//    moljac
//    Test.cs
//
//    Permission is hereby granted, free of charge, to any person
//    obtaining a copy of this software and associated documentation
//    files (the "Software"), to deal in the Software without
//    restriction, including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the
//    Software is furnished to do so, subject to the following
//    conditions:
//
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//    OTHER DEALINGS IN THE SOFTWARE.
// */

#if XUNIT
using Xunit;
// NUnit aliases
using Test = Xunit.FactAttribute;
using OneTimeSetUp = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
// XUnit aliases
using TestClass = HolisticWare.Core.Testing.UnitTests.UnitTestsCompatibilityAliasAttribute;
#elif NUNIT
using NUnit.Framework;
// MSTest aliases
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestProperty = NUnit.Framework.PropertyAttribute;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
// XUnit aliases
using Fact = NUnit.Framework.TestAttribute;
#elif MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
// NUnit aliases
using Test = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using OneTimeSetUp = Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute;
// XUnit aliases
using Fact = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
#endif

#if BENCHMARKDOTNET
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Attributes.Jobs;
#else
using Benchmark = HolisticWare.Core.Testing.BenchmarkTests.Benchmark;
#endif

using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Core.Math.Discrete.GraphTheory.Graphs;

namespace UnitTests.Core.Math.Discrete.GraphTheory.Graphs
{
    /// <summary>
    /// Test01
    /// </summary>
    /// <see href="https://en.wikipedia.org/wiki/Graph_theory#Applications"/>
    /// http://stanford.edu/~jolivier/305_refresher_notes/Basic_graph_theory_and_algorithms.pdf
    [TestClass]
    public partial class Tests20200627_Stanford_Edu_JOlivier
    {
        [Test]
        public void GraphCreate()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void MatrixAjdacency()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void ListAjdacency()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void SearchDepthFirst()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void SearchBreadthFirst()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void ConnectedComponents()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Cycles()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Cuts()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void MinimumSpanningTrees()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Complete()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Complements()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Degree()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Walk()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Trail()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Path()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Circuit()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Connectivity()
        {
            Graph g = new Graph();

            return;
        }

        [Test]
        public void Components()
        {
            Graph g = new Graph();

            return;
        }
    }
}