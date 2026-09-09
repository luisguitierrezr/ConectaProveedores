namespace ssConectaProveedores {
/// <summary>
/// [Structure] WizardApprovalDisplay (nwOEZrBLSUWkkGwNiZLUww)
///  <code>ST_3c480a6d17a69eed60b057b7ed343a1dStructure</code> that represent
/// s <code>WizardApprovalDisplay</code> <p>Description: </p>
/// </summary>
// Name: WizardApprovalDisplay
public partial struct ST_3c480a6d17a69eed60b057b7ed343a1dStructure : ITypedRecord<ST_3c480a6d17a69eed60b057b7ed343a1dStructure> {
internal static readonly GlobalObjectKey IdLevelNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ku75Rj3dtU27clOqSz9FDA");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*9JFLjcp+XkimoDkxhljzTA");
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*xmAwAPVlNUi04f29mhV9KA");
internal static readonly GlobalObjectKey IdCombinedJobTitles = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*iosMkw8LxkKUBUQ8Rj+6YA");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*FWcOSbsfs0SjLx4b5crjIg");
internal static readonly GlobalObjectKey IdIsReassigned = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*bU_A9Eaj5E6yjl9wQR3LfA");
internal static readonly GlobalObjectKey IdIsSubstituteFor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hCDt_BR350+_UECnPyyMhw");

public int ssLevelNumber;

public int ssApprovalStatusId;

public string ssName;

public string ssCombinedJobTitles;

public string ssApplicationRole;

public bool ssIsReassigned;

public string ssIsSubstituteFor;


public BitArray OptimizedAttributes;

public ST_3c480a6d17a69eed60b057b7ed343a1dStructure() {
OptimizedAttributes = null;
ssLevelNumber = 0;
ssApprovalStatusId = 0;
ssName = "";
ssCombinedJobTitles = "";
ssApplicationRole = "";
ssIsReassigned = false;
ssIsSubstituteFor = "";
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
ssLevelNumber = r.ReadInteger(index++, "WizardApprovalDisplay.LevelNumber", 0);
ssApprovalStatusId = r.ReadEntityReference(index++, "WizardApprovalDisplay.ApprovalStatusId", 0);
ssName = r.ReadText(index++, "WizardApprovalDisplay.Name", "");
ssCombinedJobTitles = r.ReadText(index++, "WizardApprovalDisplay.CombinedJobTitles", "");
ssApplicationRole = r.ReadText(index++, "WizardApprovalDisplay.ApplicationRole", "");
ssIsReassigned = r.ReadBoolean(index++, "WizardApprovalDisplay.IsReassigned", false);
ssIsSubstituteFor = r.ReadEntityReferenceText(index++, "WizardApprovalDisplay.IsSubstituteFor", "");
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
public void ReadIM(ST_3c480a6d17a69eed60b057b7ed343a1dStructure r) {
this = r;
}


public static bool operator == (ST_3c480a6d17a69eed60b057b7ed343a1dStructure a, ST_3c480a6d17a69eed60b057b7ed343a1dStructure b) {
if (a.ssLevelNumber != b.ssLevelNumber) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssName != b.ssName) return false;
if (a.ssCombinedJobTitles != b.ssCombinedJobTitles) return false;
if (a.ssApplicationRole != b.ssApplicationRole) return false;
if (a.ssIsReassigned != b.ssIsReassigned) return false;
if (a.ssIsSubstituteFor != b.ssIsSubstituteFor) return false;
return true;
}

public static bool operator != (ST_3c480a6d17a69eed60b057b7ed343a1dStructure a, ST_3c480a6d17a69eed60b057b7ed343a1dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3c480a6d17a69eed60b057b7ed343a1dStructure)) return false;
return (this == (ST_3c480a6d17a69eed60b057b7ed343a1dStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLevelNumber.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssCombinedJobTitles.GetHashCode()
 ^ ssApplicationRole.GetHashCode()
 ^ ssIsReassigned.GetHashCode()
 ^ ssIsSubstituteFor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3c480a6d17a69eed60b057b7ed343a1dStructure Duplicate() {
ST_3c480a6d17a69eed60b057b7ed343a1dStructure t;
t.ssLevelNumber = this.ssLevelNumber;
t.ssApprovalStatusId = this.ssApprovalStatusId;
t.ssName = this.ssName;
t.ssCombinedJobTitles = this.ssCombinedJobTitles;
t.ssApplicationRole = this.ssApplicationRole;
t.ssIsReassigned = this.ssIsReassigned;
t.ssIsSubstituteFor = this.ssIsSubstituteFor;
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
if (head == "levelnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LevelNumber")) variable.Value = ssLevelNumber; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "combinedjobtitles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CombinedJobTitles")) variable.Value = ssCombinedJobTitles; else variable.Optimized = true;
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssApplicationRole; else variable.Optimized = true;
} else if (head == "isreassigned") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsReassigned")) variable.Value = ssIsReassigned; else variable.Optimized = true;
} else if (head == "issubstitutefor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSubstituteFor")) variable.Value = ssIsSubstituteFor; else variable.Optimized = true;
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
if (key == IdLevelNumber) {
return ssLevelNumber;
}
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdName) {
return ssName;
}
if (key == IdCombinedJobTitles) {
return ssCombinedJobTitles;
}
if (key == IdApplicationRole) {
return ssApplicationRole;
}
if (key == IdIsReassigned) {
return ssIsReassigned;
}
if (key == IdIsSubstituteFor) {
return ssIsSubstituteFor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLevelNumber.Key.AsGuid) {
return ssLevelNumber;
}
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdCombinedJobTitles.Key.AsGuid) {
return ssCombinedJobTitles;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssApplicationRole;
}
if (attributeKey == IdIsReassigned.Key.AsGuid) {
return ssIsReassigned;
}
if (attributeKey == IdIsSubstituteFor.Key.AsGuid) {
return ssIsSubstituteFor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLevelNumber = (int) other.AttributeGet(IdLevelNumber);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ssName = (string) other.AttributeGet(IdName);
ssCombinedJobTitles = (string) other.AttributeGet(IdCombinedJobTitles);
ssApplicationRole = (string) other.AttributeGet(IdApplicationRole);
ssIsReassigned = (bool) other.AttributeGet(IdIsReassigned);
ssIsSubstituteFor = (string) other.AttributeGet(IdIsSubstituteFor);
}
} // ST_3c480a6d17a69eed60b057b7ed343a1dStructure
/// <summary>
/// RecordList type <code>WizardApprovalDisplayList</code> that represents a record list of
///  <code>WizardApprovalDisplay</code>
/// </summary>
public partial class RL_875afe918a46d044315dbe3410f1f2a7 : GenericRecordList<ST_3c480a6d17a69eed60b057b7ed343a1dStructure>, IEnumerable, IEnumerator {

protected override ST_3c480a6d17a69eed60b057b7ed343a1dStructure GetElementDefaultValue() {
return new ST_3c480a6d17a69eed60b057b7ed343a1dStructure();
}

public T[] ToArray<T>(Func<ST_3c480a6d17a69eed60b057b7ed343a1dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_875afe918a46d044315dbe3410f1f2a7 recordList, Func<ST_3c480a6d17a69eed60b057b7ed343a1dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_875afe918a46d044315dbe3410f1f2a7(ST_3c480a6d17a69eed60b057b7ed343a1dStructure[] array) {
  RL_875afe918a46d044315dbe3410f1f2a7 result = new RL_875afe918a46d044315dbe3410f1f2a7();
result.InnerFromArray(array);
    return result;
}

public static RL_875afe918a46d044315dbe3410f1f2a7 ToList<T>(T[] array, Func <T, ST_3c480a6d17a69eed60b057b7ed343a1dStructure> converter) {
  RL_875afe918a46d044315dbe3410f1f2a7 result = new RL_875afe918a46d044315dbe3410f1f2a7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_875afe918a46d044315dbe3410f1f2a7 FromRestList<T>(RestList<T> restList, Func <T, ST_3c480a6d17a69eed60b057b7ed343a1dStructure> converter) {
  RL_875afe918a46d044315dbe3410f1f2a7 result = new RL_875afe918a46d044315dbe3410f1f2a7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_875afe918a46d044315dbe3410f1f2a7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3c480a6d17a69eed60b057b7ed343a1dStructure> NewList() {
return new RL_875afe918a46d044315dbe3410f1f2a7();
}


} // RL_875afe918a46d044315dbe3410f1f2a7
}

