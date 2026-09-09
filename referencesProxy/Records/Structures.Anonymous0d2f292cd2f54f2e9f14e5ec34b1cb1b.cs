namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (LCkvDfXSLk+fFOXsNLHLGw)
///  <code>RC_b7bb8767fa20ac5740e9546367f0a67e</code> that represent
/// s <code>TI_RETENCIONES_InRecord</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_InRecord
public partial struct RC_b7bb8767fa20ac5740e9546367f0a67e : ITypedRecord<RC_b7bb8767fa20ac5740e9546367f0a67e> {
internal static readonly GlobalObjectKey IdTI_RETENCIONES_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Z4e7tyD6V6xA6VRjZ_Cmfg");

public ST_2859defd6257fe38677ed819621e4236Structure ssSTTI_RETENCIONES_In;


public static implicit operator ST_2859defd6257fe38677ed819621e4236Structure( RC_b7bb8767fa20ac5740e9546367f0a67e r) {
return r.ssSTTI_RETENCIONES_In;
}

public static implicit operator RC_b7bb8767fa20ac5740e9546367f0a67e (ST_2859defd6257fe38677ed819621e4236Structure r) {
RC_b7bb8767fa20ac5740e9546367f0a67e res = new RC_b7bb8767fa20ac5740e9546367f0a67e ();
res.ssSTTI_RETENCIONES_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b7bb8767fa20ac5740e9546367f0a67e() {
OptimizedAttributes = null;
ssSTTI_RETENCIONES_In = new ST_2859defd6257fe38677ed819621e4236Structure();
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
    ssSTTI_RETENCIONES_In.OptimizedAttributes = value[0];
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
ssSTTI_RETENCIONES_In.Read( r, ref index);
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
public void ReadIM(RC_b7bb8767fa20ac5740e9546367f0a67e r) {
this = r;
}


public static bool operator == (RC_b7bb8767fa20ac5740e9546367f0a67e a, RC_b7bb8767fa20ac5740e9546367f0a67e b) {
if (a.ssSTTI_RETENCIONES_In != b.ssSTTI_RETENCIONES_In) return false;
return true;
}

public static bool operator != (RC_b7bb8767fa20ac5740e9546367f0a67e a, RC_b7bb8767fa20ac5740e9546367f0a67e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b7bb8767fa20ac5740e9546367f0a67e)) return false;
return (this == (RC_b7bb8767fa20ac5740e9546367f0a67e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_RETENCIONES_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_RETENCIONES_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_RETENCIONES_In.InternalRecursiveSave();
}


public RC_b7bb8767fa20ac5740e9546367f0a67e Duplicate() {
RC_b7bb8767fa20ac5740e9546367f0a67e t;
t.ssSTTI_RETENCIONES_In = (ST_2859defd6257fe38677ed819621e4236Structure)this.ssSTTI_RETENCIONES_In.Duplicate();
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
if (head == "ti_retenciones_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_In")) variable.Value = ssSTTI_RETENCIONES_In; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_in");
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
if (key == IdTI_RETENCIONES_In) {
return ssSTTI_RETENCIONES_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_RETENCIONES_In.Key.AsGuid) {
return ssSTTI_RETENCIONES_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_RETENCIONES_In.FillFromOther((IRecord) other.AttributeGet(IdTI_RETENCIONES_In));
}
} // RC_b7bb8767fa20ac5740e9546367f0a67e
/// <summary>
/// RecordList type <code>TI_RETENCIONES_InRecordList</code> that represents a record list of
///  <code>TI_RETENCIONES_In</code>
/// </summary>
public partial class RL_5d188032f9aaa6f5235e7d2561f9ca85 : GenericRecordList<RC_b7bb8767fa20ac5740e9546367f0a67e>, IEnumerable, IEnumerator {

protected override RC_b7bb8767fa20ac5740e9546367f0a67e GetElementDefaultValue() {
return new RC_b7bb8767fa20ac5740e9546367f0a67e();
}

public T[] ToArray<T>(Func<RC_b7bb8767fa20ac5740e9546367f0a67e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5d188032f9aaa6f5235e7d2561f9ca85 recordList, Func<RC_b7bb8767fa20ac5740e9546367f0a67e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5d188032f9aaa6f5235e7d2561f9ca85(RC_b7bb8767fa20ac5740e9546367f0a67e[] array) {
  RL_5d188032f9aaa6f5235e7d2561f9ca85 result = new RL_5d188032f9aaa6f5235e7d2561f9ca85();
result.InnerFromArray(array);
    return result;
}

public static RL_5d188032f9aaa6f5235e7d2561f9ca85 ToList<T>(T[] array, Func <T, RC_b7bb8767fa20ac5740e9546367f0a67e> converter) {
  RL_5d188032f9aaa6f5235e7d2561f9ca85 result = new RL_5d188032f9aaa6f5235e7d2561f9ca85();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5d188032f9aaa6f5235e7d2561f9ca85 FromRestList<T>(RestList<T> restList, Func <T, RC_b7bb8767fa20ac5740e9546367f0a67e> converter) {
  RL_5d188032f9aaa6f5235e7d2561f9ca85 result = new RL_5d188032f9aaa6f5235e7d2561f9ca85();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5d188032f9aaa6f5235e7d2561f9ca85() : base() {
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
protected override OSList<RC_b7bb8767fa20ac5740e9546367f0a67e> NewList() {
return new RL_5d188032f9aaa6f5235e7d2561f9ca85();
}


} // RL_5d188032f9aaa6f5235e7d2561f9ca85
}

