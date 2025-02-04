﻿// Copyright (c) 2017-2019 Zachary Snow
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

using Zene.Structs;

namespace Zene.Graphics.Base
{
    public static unsafe partial class GL
    {
		[OpenGLSupport(1.0)]
		internal static void Enable(uint cap)
		{
			Functions.Enable(cap);
		}

		[OpenGLSupport(1.0)]
		internal static void Disable(uint cap)
		{
			Functions.Disable(cap);
		}

		internal static void SetRenderState(RenderState rs)
		{
			if (context.renderState == rs) { return; }

			if (rs == null)
			{
				rs = RenderState.Default;
				if (context.renderState == rs) { return; }
			}

			RenderState old = context.renderState;
			context.renderState = rs;

			if (old.blending != rs.blending)
			{
				if (rs.blending)
				{
					Functions.Enable(GLEnum.Blend);
				}
				else
				{
					Functions.Disable(GLEnum.Blend);
				}
			}

			if (old.faceCulling != rs.faceCulling)
			{
				if (rs.faceCulling)
				{
					Functions.Disable(GLEnum.DepthClamp);
				}
				else
				{
					Functions.Enable(GLEnum.DepthClamp);
				}
			}

			if (old.polygonMode != rs.polygonMode)
			{
				Functions.PolygonMode(GLEnum.FrontAndBack, (uint)rs.polygonMode);
			}

			if (old.ssb != rs.ssb ||
				old.dsb != rs.dsb)
			{
				Functions.BlendFunc((uint)rs.ssb, (uint)rs.dsb);
			}
		}

		[OpenGLSupport(1.0)]
		internal static void PolygonMode(uint face, PolygonMode mode)
		{
			if (context.renderState.polygonMode == mode) { return; }

			context.renderState.polygonMode = mode;

			Functions.PolygonMode(face, (uint)mode);
		}

		[OpenGLSupport(1.0)]
		internal static void BlendFunc(BlendFunction sfactor, BlendFunction dfactor)
		{
			if (sfactor == context.renderState.ssb &&
				dfactor == context.renderState.dsb)
			{
				return;
			}

			context.renderState.ssb = sfactor;
			context.renderState.dsb = dfactor;

			Functions.BlendFunc((uint)sfactor, (uint)dfactor);
		}

		internal static void SetDepthState(DepthState ds)
        {
			if (context.depth == ds) { return; }

			if (ds == null)
			{
				ds = DepthState.Default;
				if (context.depth == ds) { return; }
			}

			DepthState old = context.depth;
			context.depth = ds;

			if (old.testing != ds.testing)
            {
				if (ds.testing)
                {
					Functions.Enable(GLEnum.DepthTest);
                }
				else
                {
					Functions.Disable(GLEnum.DepthTest);
				}
            }

			if (old.clamp != ds.clamp)
			{
				if (ds.clamp)
				{
					Functions.Disable(GLEnum.DepthClamp);
				}
				else
				{
					Functions.Enable(GLEnum.DepthClamp);
				}
			}

			if (old.mask != ds.mask)
			{
				Functions.DepthMask(ds.mask);
			}

			if (old.func != ds.func)
			{
				Functions.DepthFunc((uint)ds.func);
			}

			if (old.range.X != ds.range.X ||
				old.range.Y != ds.range.Y)
			{
				Functions.DepthRange(ds.range.X, ds.range.Y);
			}
		}

		[OpenGLSupport(1.0)]
		internal static void DepthRange(floatv n, floatv f)
		{
			if (context.depth.range.X == n &&
				context.depth.range.Y == f)
			{
				return;
			}

			context.depth.range.X = n;
			context.depth.range.Y = f;

			Functions.DepthRange(n, f);
		}

		[OpenGLSupport(1.0)]
		internal static void DepthFunc(DepthFunction func)
		{
			if (context.depth.func == func) { return; }

			context.depth.func = func;

			Functions.DepthFunc((uint)func);
		}

		[OpenGLSupport(1.0)]
		internal static void DepthMask(bool flag)
		{
			if (context.depth.mask == flag) { return; }

			context.depth.mask = flag;

			Functions.DepthMask(flag);
		}

		internal static void SetViewState(Viewport vs)
        {
			if (vs == null || context.viewport == vs) { return; }

			if (context.boundFrameBuffers.Draw.LockedState &&
				context.boundFrameBuffers.Draw.Viewport != null)
			{
				return;
			}

			Viewport old = context.viewport;
			context.viewport = vs;

			if (old.view != vs.view)
            {
				Functions.Viewport(vs.view.X, vs.view.Y, vs.view.Width, vs.view.Height);
            }
        }

		[OpenGLSupport(1.0)]
		internal static void Viewport(GLBox view)
		{
			if (context.viewport.view == view) { return; }

			context.viewport.view = view;

			Functions.Viewport(view.X, view.Y, view.Width, view.Height);
		}

		internal static void SetScissorState(Scissor s)
		{
			if (context.scissor == s) { return; }

			if (s == null)
            {
				s = context.baseFrameBuffer.Scissor;
				if (context.scissor == s) { return; }
			}

			if (context.boundFrameBuffers.Draw.LockedState &&
				context.boundFrameBuffers.Draw.Scissor != null)
			{
				return;
			}

			Scissor old = context.scissor;
			context.scissor = s;

			if (old.enabled != s.enabled)
			{
				if (s.enabled)
				{
					Functions.Enable(GLEnum.ScissorTest);
				}
				else
				{
					Functions.Disable(GLEnum.ScissorTest);
				}
			}

			if (old.view != s.view)
			{
				Functions.Scissor(s.view.X, s.view.Y, s.view.Width, s.view.Height);
			}
		}

		[OpenGLSupport(1.0)]
		internal static void Scissor(GLBox bounds)
		{
			if (context.scissor.view == bounds) { return; }

			context.scissor.view = bounds;

			Functions.Scissor(bounds.X, bounds.Y, bounds.Width, bounds.Height);
		}

		[OpenGLSupport(4.1)]
		public static void ScissorArrayv(uint first, int count, int* v)
		{
			Functions.ScissorArrayv(first, count, v);
		}

		[OpenGLSupport(4.1)]
		public static void ScissorIndexed(uint index, int left, int bottom, int width, int height)
		{
			Functions.ScissorIndexed(index, left, bottom, width, height);
		}

		[OpenGLSupport(4.1)]
		public static void ScissorIndexedv(uint index, int* v)
		{
			Functions.ScissorIndexedv(index, v);
		}
	}
}
