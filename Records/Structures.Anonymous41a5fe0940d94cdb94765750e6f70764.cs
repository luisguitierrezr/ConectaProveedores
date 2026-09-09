namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Cf6lQdlA20yUdldQ5vcHZA)
///  <code>RC_09d830783dfe5460acbd192ac56050be</code> that represent
/// s <code>TI_RETENCIONES_Out3Record</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_Out3Record
public partial struct RC_09d830783dfe5460acbd192ac56050be : ITypedRecord<RC_09d830783dfe5460acbd192ac56050be> {
internal static readonly GlobalObjectKey IdTI_RETENCIONES_Out3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*eDDYCf49YFSsvRkqxWBQvg");

public ST_9fe56281b338f341e5bf9f16eeeff800Structure ssSTTI_RETENCIONES_Out3;


public static implicit operator ST_9fe56281b338f341e5bf9f16eeeff800Structure( RC_09d830783dfe5460acbd192ac56050be r) {
return r.ssSTTI_RETENCIONES_Out3;
}

public static implicit operator RC_09d830783dfe5460acbd192ac56050be (ST_9fe56281b338f341e5bf9f16eeeff800Structure r) {
RC_09d830783dfe5460acbd192ac56050be res = new RC_09d830783dfe5460acbd192ac56050be ();
res.ssSTTI_RETENCIONES_Out3 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_09d830783dfe5460acbd192ac56050be() {
OptimizedAttributes = null;
ssSTTI_RETENCIONES_Out3 = new ST_9fe56281b338f341e5bf9f16eeeff800Structure();
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
    ssSTTI_RETENCIONES_Out3.OptimizedAttributes = value[0];
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
ssSTTI_RETENCIONES_Out3.Read( r, ref index);
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
public void ReadIM(RC_09d830783dfe5460acbd192ac56050be r) {
this = r;
}


public static bool operator == (RC_09d830783dfe5460acbd192ac56050be a, RC_09d830783dfe5460acbd192ac56050be b) {
if (a.ssSTTI_RETENCIONES_Out3 != b.ssSTTI_RETENCIONES_Out3) return false;
return true;
}

public static bool operator != (RC_09d830783dfe5460acbd192ac56050be a, RC_09d830783dfe5460acbd192ac56050be b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_09d830783dfe5460acbd192ac56050be)) return false;
return (this == (RC_09d830783dfe5460acbd192ac56050be)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_RETENCIONES_Out3.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_RETENCIONES_Out3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_RETENCIONES_Out3.InternalRecursiveSave();
}


public RC_09d830783dfe5460acbd192ac56050be Duplicate() {
RC_09d830783dfe5460acbd192ac56050be t;
t.ssSTTI_RETENCIONES_Out3 = (ST_9fe56281b338f341e5bf9f16eeeff800Structure)this.ssSTTI_RETENCIONES_Out3.Duplicate();
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
if (head == "ti_retenciones_out3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_RETENCIONES_Out3")) variable.Value = ssSTTI_RETENCIONES_Out3; else variable.Optimized = true;
variable.SetFieldName("ti_retenciones_out3");
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
if (key == IdTI_RETENCIONES_Out3) {
return ssSTTI_RETENCIONES_Out3;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_RETENCIONES_Out3.Key.AsGuid) {
return ssSTTI_RETENCIONES_Out3;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_RETENCIONES_Out3.FillFromOther((IRecord) other.AttributeGet(IdTI_RETENCIONES_Out3));
}
} // RC_09d830783dfe5460acbd192ac56050be
/// <summary>
/// RecordList type <code>TI_RETENCIONES_Out3RecordList</code> that represents a record list of
///  <code>TI_RETENCIONES_Out3</code>
/// </summary>
public partial class RL_c3222870916bd931f8eeebfe34d71977 : GenericRecordList<RC_09d830783dfe5460acbd192ac56050be>, IEnumerable, IEnumerator {

protected override RC_09d830783dfe5460acbd192ac56050be GetElementDefaultValue() {
return new RC_09d830783dfe5460acbd192ac56050be();
}

public T[] ToArray<T>(Func<RC_09d830783dfe5460acbd192ac56050be, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c3222870916bd931f8eeebfe34d71977 recordList, Func<RC_09d830783dfe5460acbd192ac56050be, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c3222870916bd931f8eeebfe34d71977(RC_09d830783dfe5460acbd192ac56050be[] array) {
  RL_c3222870916bd931f8eeebfe34d71977 result = new RL_c3222870916bd931f8eeebfe34d71977();
result.InnerFromArray(array);
    return result;
}

public static RL_c3222870916bd931f8eeebfe34d71977 ToList<T>(T[] array, Func <T, RC_09d830783dfe5460acbd192ac56050be> converter) {
  RL_c3222870916bd931f8eeebfe34d71977 result = new RL_c3222870916bd931f8eeebfe34d71977();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c3222870916bd931f8eeebfe34d71977 FromRestList<T>(RestList<T> restList, Func <T, RC_09d830783dfe5460acbd192ac56050be> converter) {
  RL_c3222870916bd931f8eeebfe34d71977 result = new RL_c3222870916bd931f8eeebfe34d71977();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c3222870916bd931f8eeebfe34d71977() : base() {
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
protected override OSList<RC_09d830783dfe5460acbd192ac56050be> NewList() {
return new RL_c3222870916bd931f8eeebfe34d71977();
}


} // RL_c3222870916bd931f8eeebfe34d71977
}

