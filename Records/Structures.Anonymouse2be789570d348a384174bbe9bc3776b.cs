namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lXi+4tNwo0iEF0u+m8N3aw)
///  <code>RC_b05c1a7fbd8c144fd1f2755c12f1733a</code> that represent
/// s <code>CargaCFDResultWrapperRecord</code> <p>Description: </p>
/// </summary>
// Name: CargaCFDResultWrapperRecord
public partial struct RC_b05c1a7fbd8c144fd1f2755c12f1733a : ITypedRecord<RC_b05c1a7fbd8c144fd1f2755c12f1733a> {
internal static readonly GlobalObjectKey IdCargaCFDResultWrapper = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fxpcsIy9TxTR8nVcEvFzOg");

public ST_3feabb059aa2546826b3076d3b237751Structure ssSTCargaCFDResultWrapper;


public static implicit operator ST_3feabb059aa2546826b3076d3b237751Structure( RC_b05c1a7fbd8c144fd1f2755c12f1733a r) {
return r.ssSTCargaCFDResultWrapper;
}

public static implicit operator RC_b05c1a7fbd8c144fd1f2755c12f1733a (ST_3feabb059aa2546826b3076d3b237751Structure r) {
RC_b05c1a7fbd8c144fd1f2755c12f1733a res = new RC_b05c1a7fbd8c144fd1f2755c12f1733a ();
res.ssSTCargaCFDResultWrapper = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b05c1a7fbd8c144fd1f2755c12f1733a() {
OptimizedAttributes = null;
ssSTCargaCFDResultWrapper = new ST_3feabb059aa2546826b3076d3b237751Structure();
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
    ssSTCargaCFDResultWrapper.OptimizedAttributes = value[0];
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
ssSTCargaCFDResultWrapper.Read( r, ref index);
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
public void ReadIM(RC_b05c1a7fbd8c144fd1f2755c12f1733a r) {
this = r;
}


public static bool operator == (RC_b05c1a7fbd8c144fd1f2755c12f1733a a, RC_b05c1a7fbd8c144fd1f2755c12f1733a b) {
if (a.ssSTCargaCFDResultWrapper != b.ssSTCargaCFDResultWrapper) return false;
return true;
}

public static bool operator != (RC_b05c1a7fbd8c144fd1f2755c12f1733a a, RC_b05c1a7fbd8c144fd1f2755c12f1733a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b05c1a7fbd8c144fd1f2755c12f1733a)) return false;
return (this == (RC_b05c1a7fbd8c144fd1f2755c12f1733a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCargaCFDResultWrapper.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCargaCFDResultWrapper.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCargaCFDResultWrapper.InternalRecursiveSave();
}


public RC_b05c1a7fbd8c144fd1f2755c12f1733a Duplicate() {
RC_b05c1a7fbd8c144fd1f2755c12f1733a t;
t.ssSTCargaCFDResultWrapper = (ST_3feabb059aa2546826b3076d3b237751Structure)this.ssSTCargaCFDResultWrapper.Duplicate();
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
if (head == "cargacfdresultwrapper") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CargaCFDResultWrapper")) variable.Value = ssSTCargaCFDResultWrapper; else variable.Optimized = true;
variable.SetFieldName("cargacfdresultwrapper");
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
if (key == IdCargaCFDResultWrapper) {
return ssSTCargaCFDResultWrapper;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCargaCFDResultWrapper.Key.AsGuid) {
return ssSTCargaCFDResultWrapper;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCargaCFDResultWrapper.FillFromOther((IRecord) other.AttributeGet(IdCargaCFDResultWrapper));
}
} // RC_b05c1a7fbd8c144fd1f2755c12f1733a
/// <summary>
/// RecordList type <code>CargaCFDResultWrapperRecordList</code> that represents a record list of
///  <code>CargaCFDResultWrapper</code>
/// </summary>
public partial class RL_6c6d07c5f8e4f07d210407f4534b99ae : GenericRecordList<RC_b05c1a7fbd8c144fd1f2755c12f1733a>, IEnumerable, IEnumerator {

protected override RC_b05c1a7fbd8c144fd1f2755c12f1733a GetElementDefaultValue() {
return new RC_b05c1a7fbd8c144fd1f2755c12f1733a();
}

public T[] ToArray<T>(Func<RC_b05c1a7fbd8c144fd1f2755c12f1733a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6c6d07c5f8e4f07d210407f4534b99ae recordList, Func<RC_b05c1a7fbd8c144fd1f2755c12f1733a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6c6d07c5f8e4f07d210407f4534b99ae(RC_b05c1a7fbd8c144fd1f2755c12f1733a[] array) {
  RL_6c6d07c5f8e4f07d210407f4534b99ae result = new RL_6c6d07c5f8e4f07d210407f4534b99ae();
result.InnerFromArray(array);
    return result;
}

public static RL_6c6d07c5f8e4f07d210407f4534b99ae ToList<T>(T[] array, Func <T, RC_b05c1a7fbd8c144fd1f2755c12f1733a> converter) {
  RL_6c6d07c5f8e4f07d210407f4534b99ae result = new RL_6c6d07c5f8e4f07d210407f4534b99ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6c6d07c5f8e4f07d210407f4534b99ae FromRestList<T>(RestList<T> restList, Func <T, RC_b05c1a7fbd8c144fd1f2755c12f1733a> converter) {
  RL_6c6d07c5f8e4f07d210407f4534b99ae result = new RL_6c6d07c5f8e4f07d210407f4534b99ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6c6d07c5f8e4f07d210407f4534b99ae() : base() {
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
protected override OSList<RC_b05c1a7fbd8c144fd1f2755c12f1733a> NewList() {
return new RL_6c6d07c5f8e4f07d210407f4534b99ae();
}


} // RL_6c6d07c5f8e4f07d210407f4534b99ae
}

