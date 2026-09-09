namespace ssConectaProveedores {
/// <summary>
/// [Structure] EmailNotifTesoraria (fgV1T_OSS0acGwqAcJj_Jg)
///  <code>ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure</code> that represent
/// s <code>EmailNotifTesoraria</code> <p>Description: Email Notification Tesoraria Struct.</p>
/// </summary>
// Name: EmailNotifTesoraria
public partial struct ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure : ITypedRecord<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> {
internal static readonly GlobalObjectKey IdApprovedCount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NRUo8UOmX0W7Zw79UBoTsw");
internal static readonly GlobalObjectKey IdApprovedNames = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*tNQJu8nxC0Wmx+kEmMU3Og");
internal static readonly GlobalObjectKey IdBeingPaidCount = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QcqK1CrdeU+mYoYDr6GnHg");
internal static readonly GlobalObjectKey IdBeingPaidNames = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*sdWjRZul_UOu5DFmATqbNw");

public int ssApprovedCount;

public string ssApprovedNames;

public int ssBeingPaidCount;

public string ssBeingPaidNames;


public BitArray OptimizedAttributes;

public ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure() {
OptimizedAttributes = null;
ssApprovedCount = 0;
ssApprovedNames = "";
ssBeingPaidCount = 0;
ssBeingPaidNames = "";
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
ssApprovedCount = r.ReadInteger(index++, "EmailNotifTesoraria.ApprovedCount", 0);
ssApprovedNames = r.ReadText(index++, "EmailNotifTesoraria.ApprovedNames", "");
ssBeingPaidCount = r.ReadInteger(index++, "EmailNotifTesoraria.BeingPaidCount", 0);
ssBeingPaidNames = r.ReadText(index++, "EmailNotifTesoraria.BeingPaidNames", "");
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
public void ReadIM(ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure r) {
this = r;
}


public static bool operator == (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure a, ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure b) {
if (a.ssApprovedCount != b.ssApprovedCount) return false;
if (a.ssApprovedNames != b.ssApprovedNames) return false;
if (a.ssBeingPaidCount != b.ssBeingPaidCount) return false;
if (a.ssBeingPaidNames != b.ssBeingPaidNames) return false;
return true;
}

public static bool operator != (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure a, ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure)) return false;
return (this == (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssApprovedCount.GetHashCode()
 ^ ssApprovedNames.GetHashCode()
 ^ ssBeingPaidCount.GetHashCode()
 ^ ssBeingPaidNames.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure Duplicate() {
ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure t;
t.ssApprovedCount = this.ssApprovedCount;
t.ssApprovedNames = this.ssApprovedNames;
t.ssBeingPaidCount = this.ssBeingPaidCount;
t.ssBeingPaidNames = this.ssBeingPaidNames;
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
if (head == "approvedcount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedCount")) variable.Value = ssApprovedCount; else variable.Optimized = true;
} else if (head == "approvednames") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovedNames")) variable.Value = ssApprovedNames; else variable.Optimized = true;
} else if (head == "beingpaidcount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BeingPaidCount")) variable.Value = ssBeingPaidCount; else variable.Optimized = true;
} else if (head == "beingpaidnames") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BeingPaidNames")) variable.Value = ssBeingPaidNames; else variable.Optimized = true;
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
if (key == IdApprovedCount) {
return ssApprovedCount;
}
if (key == IdApprovedNames) {
return ssApprovedNames;
}
if (key == IdBeingPaidCount) {
return ssBeingPaidCount;
}
if (key == IdBeingPaidNames) {
return ssBeingPaidNames;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApprovedCount.Key.AsGuid) {
return ssApprovedCount;
}
if (attributeKey == IdApprovedNames.Key.AsGuid) {
return ssApprovedNames;
}
if (attributeKey == IdBeingPaidCount.Key.AsGuid) {
return ssBeingPaidCount;
}
if (attributeKey == IdBeingPaidNames.Key.AsGuid) {
return ssBeingPaidNames;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssApprovedCount = (int) other.AttributeGet(IdApprovedCount);
ssApprovedNames = (string) other.AttributeGet(IdApprovedNames);
ssBeingPaidCount = (int) other.AttributeGet(IdBeingPaidCount);
ssBeingPaidNames = (string) other.AttributeGet(IdBeingPaidNames);
}
} // ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure
/// <summary>
/// RecordList type <code>EmailNotifTesorariaList</code> that represents a record list of
///  <code>EmailNotifTesoraria</code>
/// </summary>
public partial class RL_ff491957d48cf4e964bd23b0f75e466e : GenericRecordList<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure>, IEnumerable, IEnumerator {

protected override ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure GetElementDefaultValue() {
return new ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure();
}

public T[] ToArray<T>(Func<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ff491957d48cf4e964bd23b0f75e466e recordList, Func<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ff491957d48cf4e964bd23b0f75e466e(ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure[] array) {
  RL_ff491957d48cf4e964bd23b0f75e466e result = new RL_ff491957d48cf4e964bd23b0f75e466e();
result.InnerFromArray(array);
    return result;
}

public static RL_ff491957d48cf4e964bd23b0f75e466e ToList<T>(T[] array, Func <T, ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> converter) {
  RL_ff491957d48cf4e964bd23b0f75e466e result = new RL_ff491957d48cf4e964bd23b0f75e466e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ff491957d48cf4e964bd23b0f75e466e FromRestList<T>(RestList<T> restList, Func <T, ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> converter) {
  RL_ff491957d48cf4e964bd23b0f75e466e result = new RL_ff491957d48cf4e964bd23b0f75e466e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ff491957d48cf4e964bd23b0f75e466e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> NewList() {
return new RL_ff491957d48cf4e964bd23b0f75e466e();
}


} // RL_ff491957d48cf4e964bd23b0f75e466e
}

