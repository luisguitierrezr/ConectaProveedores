namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lF8ZiQeUM0GXmywwr67p9Q)
///  <code>RC_afab2cefd38800554ad4d08254da5d01</code> that represent
/// s <code>ApprovalStatusIdLabelESCountRecord</code> <p>Description: </p>
/// </summary>
// Name: ApprovalStatusIdLabelESCountRecord
public partial struct RC_afab2cefd38800554ad4d08254da5d01 : ITypedRecord<RC_afab2cefd38800554ad4d08254da5d01> {
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*6ypBFlSbld05qFNFQCLhdw");
internal static readonly GlobalObjectKey IdLabelES = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5ztryVZbP_nShXkqSTeB6Q");
internal static readonly GlobalObjectKey IdCount = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Hf+xdpZqUjewQd_vPxy4NQ");

public int ssApprovalStatusId;

public string ssLabelES;

public long ssCount;


public BitArray OptimizedAttributes;

public RC_afab2cefd38800554ad4d08254da5d01() {
OptimizedAttributes = null;
ssApprovalStatusId = 0;
ssLabelES = "";
ssCount = 0L;
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
ssApprovalStatusId = r.ReadEntityReference(index++, "ApprovalStatusIdLabelESCountRecord.ApprovalStatusId", 0);
ssLabelES = r.ReadText(index++, "ApprovalStatusIdLabelESCountRecord.LabelES", "");
ssCount = r.ReadLongInteger(index++, "ApprovalStatusIdLabelESCountRecord.Count", 0L);
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
public void ReadIM(RC_afab2cefd38800554ad4d08254da5d01 r) {
this = r;
}


public static bool operator == (RC_afab2cefd38800554ad4d08254da5d01 a, RC_afab2cefd38800554ad4d08254da5d01 b) {
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssLabelES != b.ssLabelES) return false;
if (a.ssCount != b.ssCount) return false;
return true;
}

public static bool operator != (RC_afab2cefd38800554ad4d08254da5d01 a, RC_afab2cefd38800554ad4d08254da5d01 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_afab2cefd38800554ad4d08254da5d01)) return false;
return (this == (RC_afab2cefd38800554ad4d08254da5d01)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssLabelES.GetHashCode()
 ^ ssCount.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_afab2cefd38800554ad4d08254da5d01 Duplicate() {
RC_afab2cefd38800554ad4d08254da5d01 t;
t.ssApprovalStatusId = this.ssApprovalStatusId;
t.ssLabelES = this.ssLabelES;
t.ssCount = this.ssCount;
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
if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "labeles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LabelES")) variable.Value = ssLabelES; else variable.Optimized = true;
} else if (head == "count") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Count")) variable.Value = ssCount; else variable.Optimized = true;
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
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdLabelES) {
return ssLabelES;
}
if (key == IdCount) {
return ssCount;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdLabelES.Key.AsGuid) {
return ssLabelES;
}
if (attributeKey == IdCount.Key.AsGuid) {
return ssCount;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ssLabelES = (string) other.AttributeGet(IdLabelES);
ssCount = (long) other.AttributeGet(IdCount);
}
} // RC_afab2cefd38800554ad4d08254da5d01
/// <summary>
/// RecordList type <code>ApprovalStatusIdLabelESCountRecordList</code> that represents a record list
///  of <code>ApprovalStatusIdentifier, Text, LongInteger</code>
/// </summary>
public partial class RL_0922ef0d81dca2b2738e948c81f0647f : GenericRecordList<RC_afab2cefd38800554ad4d08254da5d01>, IEnumerable, IEnumerator {

protected override RC_afab2cefd38800554ad4d08254da5d01 GetElementDefaultValue() {
return new RC_afab2cefd38800554ad4d08254da5d01();
}

public T[] ToArray<T>(Func<RC_afab2cefd38800554ad4d08254da5d01, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0922ef0d81dca2b2738e948c81f0647f recordList, Func<RC_afab2cefd38800554ad4d08254da5d01, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0922ef0d81dca2b2738e948c81f0647f(RC_afab2cefd38800554ad4d08254da5d01[] array) {
  RL_0922ef0d81dca2b2738e948c81f0647f result = new RL_0922ef0d81dca2b2738e948c81f0647f();
result.InnerFromArray(array);
    return result;
}

public static RL_0922ef0d81dca2b2738e948c81f0647f ToList<T>(T[] array, Func <T, RC_afab2cefd38800554ad4d08254da5d01> converter) {
  RL_0922ef0d81dca2b2738e948c81f0647f result = new RL_0922ef0d81dca2b2738e948c81f0647f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0922ef0d81dca2b2738e948c81f0647f FromRestList<T>(RestList<T> restList, Func <T, RC_afab2cefd38800554ad4d08254da5d01> converter) {
  RL_0922ef0d81dca2b2738e948c81f0647f result = new RL_0922ef0d81dca2b2738e948c81f0647f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0922ef0d81dca2b2738e948c81f0647f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_afab2cefd38800554ad4d08254da5d01> NewList() {
return new RL_0922ef0d81dca2b2738e948c81f0647f();
}


} // RL_0922ef0d81dca2b2738e948c81f0647f
}

