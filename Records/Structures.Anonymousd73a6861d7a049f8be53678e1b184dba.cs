namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (YWg616DX+Em+U2eOGxhNug)
///  <code>RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f</code> that represent
/// s <code>TI_RETENCIONES_In3Record</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_In3Record
public partial struct RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f : ITypedRecord<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> {
internal static readonly GlobalObjectKey IdTI_RETENCIONES_In3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7fPxflbNtPZ9bmBO1u4PHw");

public ST_57edec30140ebe846267970253841d11Structure ssSTTI_RETENCIONES_In3;


public static implicit operator ST_57edec30140ebe846267970253841d11Structure( RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f r) {
return r.ssSTTI_RETENCIONES_In3;
}

public static implicit operator RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f (ST_57edec30140ebe846267970253841d11Structure r) {
RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f res = new RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f ();
res.ssSTTI_RETENCIONES_In3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f() {
OptimizedAttributes = null;
ssSTTI_RETENCIONES_In3 = new ST_57edec30140ebe846267970253841d11Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTTI_RETENCIONES_In3.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTTI_RETENCIONES_In3.Read( r, ref index);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f r) {
this = r;
}


public static bool operator == (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f a, RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f b) {
if (a.ssSTTI_RETENCIONES_In3 != b.ssSTTI_RETENCIONES_In3) return false;
return true;
}

public static bool operator != (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f a, RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f)) return false;
return (this == (RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_RETENCIONES_In3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_RETENCIONES_In3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_RETENCIONES_In3.InternalRecursiveSave();
}


public RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f Duplicate() {
RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f t;
t.ssSTTI_RETENCIONES_In3 = (ST_57edec30140ebe846267970253841d11Structure)this.ssSTTI_RETENCIONES_In3.Duplicate();
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "ti_retenciones_in3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_In3")) variable.Value = ssSTTI_RETENCIONES_In3; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_in3");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTI_RETENCIONES_In3) {
return ssSTTI_RETENCIONES_In3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_RETENCIONES_In3.Key.AsGuid) {
return ssSTTI_RETENCIONES_In3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_RETENCIONES_In3.FillFromOther((IRecord) other.AttributeGet(IdTI_RETENCIONES_In3));
}
} // RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f
/// <summary>
/// RecordList type <code>TI_RETENCIONES_In3RecordList</code> that represents a record list of
///  <code>TI_RETENCIONES_In3</code>
/// </summary>
public partial class RL_6c626ffe9bd94b81a2dcf88500382df0 : GenericRecordList<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f>, IEnumerable, IEnumerator {

protected override RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f GetElementDefaultValue() {
return new RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f();
}

public T[] ToArray<T>(Func<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6c626ffe9bd94b81a2dcf88500382df0 recordList, Func<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6c626ffe9bd94b81a2dcf88500382df0(RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f[] array) {
  RL_6c626ffe9bd94b81a2dcf88500382df0 result = new RL_6c626ffe9bd94b81a2dcf88500382df0();
result.InnerFromArray(array);
    return result;
}

public static RL_6c626ffe9bd94b81a2dcf88500382df0 ToList<T>(T[] array, Func <T, RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> converter) {
  RL_6c626ffe9bd94b81a2dcf88500382df0 result = new RL_6c626ffe9bd94b81a2dcf88500382df0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6c626ffe9bd94b81a2dcf88500382df0 FromRestList<T>(RestList<T> restList, Func <T, RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> converter) {
  RL_6c626ffe9bd94b81a2dcf88500382df0 result = new RL_6c626ffe9bd94b81a2dcf88500382df0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6c626ffe9bd94b81a2dcf88500382df0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7ef1f3edcd56f6b47d6e604ed6ee0f1f> NewList() {
return new RL_6c626ffe9bd94b81a2dcf88500382df0();
}


} // RL_6c626ffe9bd94b81a2dcf88500382df0
}

