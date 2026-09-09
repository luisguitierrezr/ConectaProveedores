namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (zWXb6Uv0iU+acpRQUX6gKw)
///  <code>RC_1b6a0ce1f3825bc6a50605a3cd525b9e</code> that represent
/// s <code>OrderApprovaLevelIdOrderMainIdRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovaLevelIdOrderMainIdRecord
public partial struct RC_1b6a0ce1f3825bc6a50605a3cd525b9e : ITypedRecord<RC_1b6a0ce1f3825bc6a50605a3cd525b9e> {
internal static readonly GlobalObjectKey IdOrderApprovaLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*pm2MF9TgcS5okOH6TcZhCA");
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VMdL9U7_4X6FxwfV55xiag");

public long ssOrderApprovaLevelId;

public long ssOrderMainId;


public BitArray OptimizedAttributes;

public RC_1b6a0ce1f3825bc6a50605a3cd525b9e() {
OptimizedAttributes = null;
ssOrderApprovaLevelId = 0L;
ssOrderMainId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssOrderApprovaLevelId = r.ReadEntityReferenceLongInteger(index++, "OrderApprovaLevelIdOrderMainIdRecord.OrderApprovaLevelId", 0L);
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "OrderApprovaLevelIdOrderMainIdRecord.OrderMainId", 0L);
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
public void ReadIM(RC_1b6a0ce1f3825bc6a50605a3cd525b9e r) {
this = r;
}


public static bool operator == (RC_1b6a0ce1f3825bc6a50605a3cd525b9e a, RC_1b6a0ce1f3825bc6a50605a3cd525b9e b) {
if (a.ssOrderApprovaLevelId != b.ssOrderApprovaLevelId) return false;
if (a.ssOrderMainId != b.ssOrderMainId) return false;
return true;
}

public static bool operator != (RC_1b6a0ce1f3825bc6a50605a3cd525b9e a, RC_1b6a0ce1f3825bc6a50605a3cd525b9e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1b6a0ce1f3825bc6a50605a3cd525b9e)) return false;
return (this == (RC_1b6a0ce1f3825bc6a50605a3cd525b9e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssOrderApprovaLevelId.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_1b6a0ce1f3825bc6a50605a3cd525b9e Duplicate() {
RC_1b6a0ce1f3825bc6a50605a3cd525b9e t;
t.ssOrderApprovaLevelId = this.ssOrderApprovaLevelId;
t.ssOrderMainId = this.ssOrderMainId;
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
if (head == "orderapprovalevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovaLevelId")) variable.Value = ssOrderApprovaLevelId; else variable.Optimized = true;
} else if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
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
if (key == IdOrderApprovaLevelId) {
return ssOrderApprovaLevelId;
}
if (key == IdOrderMainId) {
return ssOrderMainId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApprovaLevelId.Key.AsGuid) {
return ssOrderApprovaLevelId;
}
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssOrderApprovaLevelId = (long) other.AttributeGet(IdOrderApprovaLevelId);
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
}
} // RC_1b6a0ce1f3825bc6a50605a3cd525b9e
/// <summary>
/// RecordList type <code>OrderApprovaLevelIdOrderMainIdRecordList</code> that represents a record list
///  of <code>OrderApprovalLevelIdentifier, OrderMainIdentifier</code>
/// </summary>
public partial class RL_ae86137c3849df82f874f36658b7a66a : GenericRecordList<RC_1b6a0ce1f3825bc6a50605a3cd525b9e>, IEnumerable, IEnumerator {

protected override RC_1b6a0ce1f3825bc6a50605a3cd525b9e GetElementDefaultValue() {
return new RC_1b6a0ce1f3825bc6a50605a3cd525b9e();
}

public T[] ToArray<T>(Func<RC_1b6a0ce1f3825bc6a50605a3cd525b9e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ae86137c3849df82f874f36658b7a66a recordList, Func<RC_1b6a0ce1f3825bc6a50605a3cd525b9e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ae86137c3849df82f874f36658b7a66a(RC_1b6a0ce1f3825bc6a50605a3cd525b9e[] array) {
  RL_ae86137c3849df82f874f36658b7a66a result = new RL_ae86137c3849df82f874f36658b7a66a();
result.InnerFromArray(array);
    return result;
}

public static RL_ae86137c3849df82f874f36658b7a66a ToList<T>(T[] array, Func <T, RC_1b6a0ce1f3825bc6a50605a3cd525b9e> converter) {
  RL_ae86137c3849df82f874f36658b7a66a result = new RL_ae86137c3849df82f874f36658b7a66a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ae86137c3849df82f874f36658b7a66a FromRestList<T>(RestList<T> restList, Func <T, RC_1b6a0ce1f3825bc6a50605a3cd525b9e> converter) {
  RL_ae86137c3849df82f874f36658b7a66a result = new RL_ae86137c3849df82f874f36658b7a66a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ae86137c3849df82f874f36658b7a66a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1b6a0ce1f3825bc6a50605a3cd525b9e> NewList() {
return new RL_ae86137c3849df82f874f36658b7a66a();
}


} // RL_ae86137c3849df82f874f36658b7a66a
}

