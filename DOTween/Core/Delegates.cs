﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2014/05/05 13:29
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace DG.Tweening.Core
{
    /// <summary>
    /// Used in place of <c>System.Func</c>, which is not available in mscorlib.
    /// </summary>
    public delegate T DOGetter<out T>();

    /// <summary>
    /// Used in place of <c>System.Action</c>.
    /// </summary>
    public delegate void DOSetter<in T>(T pNewValue);

    /// <summary>
    /// Used for tween callbacks
    /// </summary>
    public delegate void TweenCallback();

    /// <summary>
    /// Used for custom and animationCurve-based ease functions
    /// </summary>
    public delegate float EaseFunction(float time, float startValue, float changeValue, float duration, float overshootOrAmplitude, float period);
}