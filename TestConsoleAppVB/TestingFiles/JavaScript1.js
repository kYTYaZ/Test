﻿/*
 * Copyright (c) 2010 Nick Galbreath
 * http://code.google.com/p/stringencoders/source/browse/#svn/trunk/javascript
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 */
var base64 = {};
base64.PADCHAR = '=';
base64.ALPHA = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/';
base64.makeDOMException = function () {
    var e, tmp;
    try {
        return new DOMException(DOMException.INVALID_CHARACTER_ERR)
    } catch (tmp) {
        var a = new Error("DOM Exception 5");
        a.code = a.number = 5;
        a.name = a.description = "INVALID_CHARACTER_ERR";
        a.toString = function () {
            return 'Error: ' + a.name + ': ' + a.message
        }; return a
    }
};
base64.getbyte64 = function (s, i) {
    var a = base64.ALPHA.indexOf(s.charAt(i));
    if (a === -1) {
        throw base64.makeDOMException();
    } return a
};
base64.decode = function (s) {
    s = '' + s;
    var a = base64.getbyte64;
    var b, i, b10;
    var c = s.length;
    if (c === 0) { return s }
    if (c % 4 !== 0) { throw base64.makeDOMException(); }
    b = 0;
    if (s.charAt(c - 1) === base64.PADCHAR) {
        b = 1;
        if (s.charAt(c - 2) === base64.PADCHAR) {
            b = 2
        } c -= 4
    } var x = [];
    for (i = 0; i < c; i += 4) {
        b10 = (a(s, i) << 18) | (a(s, i + 1) << 12) | (a(s, i + 2) << 6) | a(s, i + 3);
        x.push(String.fromCharCode(b10 >> 16,
            (b10 >> 8) & 0xff, b10 & 0xff))
    }
    switch (b) {
        case 1:
            b10 = (a(s, i) << 18) | (a(s, i + 1) << 12) | (a(s, i + 2) << 6); x.push(String.fromCharCode(b10 >> 16, (b10 >> 8) & 0xff));
            break;
        case 2:
            b10 = (a(s, i) << 18) | (a(s, i + 1) << 12); x.push(String.fromCharCode(b10 >> 16));
            break
    }return x.join('')
};
base64.getbyte = function (s, i) {
    var x = s.charCodeAt(i);
    if (x > 255) {
        throw base64.makeDOMException();
    } return x
};
base64.encode = function (s) { if (arguments.length !== 1) { throw new SyntaxError("Not enough arguments"); } var a = base64.PADCHAR; var b = base64.ALPHA; var c = base64.getbyte; var i, b10; var x = []; s = '' + s; var d = s.length - s.length % 3; if (s.length === 0) { return s } for (i = 0; i < d; i += 3) { b10 = (c(s, i) << 16) | (c(s, i + 1) << 8) | c(s, i + 2); x.push(b.charAt(b10 >> 18)); x.push(b.charAt((b10 >> 12) & 0x3F)); x.push(b.charAt((b10 >> 6) & 0x3f)); x.push(b.charAt(b10 & 0x3f)) } switch (s.length - d) { case 1: b10 = c(s, i) << 16; x.push(b.charAt(b10 >> 18) + b.charAt((b10 >> 12) & 0x3F) + a + a); break; case 2: b10 = (c(s, i) << 16) | (c(s, i + 1) << 8); x.push(b.charAt(b10 >> 18) + b.charAt((b10 >> 12) & 0x3F) + b.charAt((b10 >> 6) & 0x3f) + a); break }return x.join('') };
