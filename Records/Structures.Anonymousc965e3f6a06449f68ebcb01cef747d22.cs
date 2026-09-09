namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9uNlyWSg9kmOvLAc73R9Ig)
///  <code>RC_9162f01c71226303cd0e14f0309ed1b9</code> that represent
/// s <code>TI_RETENCIONES_OutRecord</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_OutRecord
public partial struct RC_9162f01c71226303cd0e14f0309ed1b9 : ITypedRecord<RC_9162f01c71226303cd0e14f0309ed1b9> {
internal static readonly GlobalObjectKey IdTI_RETENCIONES_Out = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*HPBikSJxA2PNDhTwMJ7RuQ");

public ST_9e0fb2735a5b1c9875cbba9ab856e646Structure ssSTTI_RETENCIONES_Out;


public static implicit operator ST_9e0fb2735a5b1c9875cbba9ab856e646Structure( RC_9162f01c71226303cd0e14f0309ed1b9 r) {
return r.ssSTTI_RETENCIONES_Out;
}

public static implicit operator RC_9162f01c71226303cd0e14f0309ed1b9 (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure r) {
RC_9162f01c71226303cd0e14f0309ed1b9 res = new RC_9162f01c71226303cd0e14f0309ed1b9 ();
res.ssSTTI_RETENCIONES_Out = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9162f01c71226303cd0e14f0309ed1b9() {
OptimizedAttributes = null;
ssSTTI_RETENCIONES_Out = new ST_9e0fb2735a5b1c9875cbba9ab856e646Structure();
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
    ssSTTI_RETENCIONES_Out.OptimizedAttributes = value[0];
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
ssSTTI_RETENCIONES_Out.Read( r, ref index);
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
public void ReadIM(RC_9162f01c71226303cd0e14f0309ed1b9 r) {
this = r;
}


public static bool operator == (RC_9162f01c71226303cd0e14f0309ed1b9 a, RC_9162f01c71226303cd0e14f0309ed1b9 b) {
if (a.ssSTTI_RETENCIONES_Out != b.ssSTTI_RETENCIONES_Out) return false;
return true;
}

public static bool operator != (RC_9162f01c71226303cd0e14f0309ed1b9 a, RC_9162f01c71226303cd0e14f0309ed1b9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9162f01c71226303cd0e14f0309ed1b9)) return false;
return (this == (RC_9162f01c71226303cd0e14f0309ed1b9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_RETENCIONES_Out.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_RETENCIONES_Out.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_RETENCIONES_Out.InternalRecursiveSave();
}


public RC_9162f01c71226303cd0e14f0309ed1b9 Duplicate() {
RC_9162f01c71226303cd0e14f0309ed1b9 t;
t.ssSTTI_RETENCIONES_Out = (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure)this.ssSTTI_RETENCIONES_Out.Duplicate();
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
if (head == "ti_retenciones_out") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_Out")) variable.Value = ssSTTI_RETENCIONES_Out; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_out");
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
if (key == IdTI_RETENCIONES_Out) {
return ssSTTI_RETENCIONES_Out;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_RETENCIONES_Out.Key.AsGuid) {
return ssSTTI_RETENCIONES_Out;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_RETENCIONES_Out.FillFromOther((IRecord) other.AttributeGet(IdTI_RETENCIONES_Out));
}
} // RC_9162f01c71226303cd0e14f0309ed1b9
/// <summary>
/// RecordList type <code>TI_RETENCIONES_OutRecordList</code> that represents a record list of
///  <code>TI_RETENCIONES_Out</code>
/// </summary>
public partial class RL_ab902f96b6e6e875ba72e6fc6edc0a7b : GenericRecordList<RC_9162f01c71226303cd0e14f0309ed1b9>, IEnumerable, IEnumerator {

protected override RC_9162f01c71226303cd0e14f0309ed1b9 GetElementDefaultValue() {
return new RC_9162f01c71226303cd0e14f0309ed1b9();
}

public T[] ToArray<T>(Func<RC_9162f01c71226303cd0e14f0309ed1b9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ab902f96b6e6e875ba72e6fc6edc0a7b recordList, Func<RC_9162f01c71226303cd0e14f0309ed1b9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ab902f96b6e6e875ba72e6fc6edc0a7b(RC_9162f01c71226303cd0e14f0309ed1b9[] array) {
  RL_ab902f96b6e6e875ba72e6fc6edc0a7b result = new RL_ab902f96b6e6e875ba72e6fc6edc0a7b();
result.InnerFromArray(array);
    return result;
}

public static RL_ab902f96b6e6e875ba72e6fc6edc0a7b ToList<T>(T[] array, Func <T, RC_9162f01c71226303cd0e14f0309ed1b9> converter) {
  RL_ab902f96b6e6e875ba72e6fc6edc0a7b result = new RL_ab902f96b6e6e875ba72e6fc6edc0a7b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ab902f96b6e6e875ba72e6fc6edc0a7b FromRestList<T>(RestList<T> restList, Func <T, RC_9162f01c71226303cd0e14f0309ed1b9> converter) {
  RL_ab902f96b6e6e875ba72e6fc6edc0a7b result = new RL_ab902f96b6e6e875ba72e6fc6edc0a7b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ab902f96b6e6e875ba72e6fc6edc0a7b() : base() {
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
protected override OSList<RC_9162f01c71226303cd0e14f0309ed1b9> NewList() {
return new RL_ab902f96b6e6e875ba72e6fc6edc0a7b();
}


} // RL_ab902f96b6e6e875ba72e6fc6edc0a7b
}

