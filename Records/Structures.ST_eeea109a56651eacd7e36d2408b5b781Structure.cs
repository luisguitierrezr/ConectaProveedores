namespace ssConectaProveedores {
/// <summary>
/// [Structure] OrderDistributionImportStruc (mBqDO4pB40GMiNAi653nBw)
///  <code>ST_eeea109a56651eacd7e36d2408b5b781Structure</code> that represent
/// s <code>OrderDistributionImportStruc</code> <p>Description: </p>
/// </summary>
// Name: OrderDistributionImportStruc
public partial struct ST_eeea109a56651eacd7e36d2408b5b781Structure : ITypedRecord<ST_eeea109a56651eacd7e36d2408b5b781Structure> {
internal static readonly GlobalObjectKey IdDivision = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2knxO_L9wk+grgQIbfHqsw");
internal static readonly GlobalObjectKey IdApplicant = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oW6wqvgDyU+8ijNanmd1yw");
internal static readonly GlobalObjectKey IdApplicantDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YPlUCn4JMEu5ME7GPO1pLQ");
internal static readonly GlobalObjectKey IdDirection = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XwKIo1Afq0GWS5RGcDndSg");
internal static readonly GlobalObjectKey IdFirstContact = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JD8wAC2On0WggvxkelOm+Q");
internal static readonly GlobalObjectKey IdSecondContact = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1q7i+h311kCX1QuCA5MtTQ");
internal static readonly GlobalObjectKey IdFirstApprover = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ntExJGCfV0aoq+E52F_dhQ");
internal static readonly GlobalObjectKey IdSecondApprover = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*WmmnTHeNvkKrB157LdoNBg");

public string ssDivision;

public string ssApplicant;

public string ssApplicantDescription;

public string ssDirection;

public string ssFirstContact;

public string ssSecondContact;

public string ssFirstApprover;

public string ssSecondApprover;


public BitArray OptimizedAttributes;

public ST_eeea109a56651eacd7e36d2408b5b781Structure() {
OptimizedAttributes = null;
ssDivision = "";
ssApplicant = "";
ssApplicantDescription = "";
ssDirection = "";
ssFirstContact = "";
ssSecondContact = "";
ssFirstApprover = "";
ssSecondApprover = "";
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
ssDivision = r.ReadText(index++, "OrderDistributionImportStruc.Division", "");
ssApplicant = r.ReadText(index++, "OrderDistributionImportStruc.Applicant", "");
ssApplicantDescription = r.ReadText(index++, "OrderDistributionImportStruc.ApplicantDescription", "");
ssDirection = r.ReadText(index++, "OrderDistributionImportStruc.Direction", "");
ssFirstContact = r.ReadText(index++, "OrderDistributionImportStruc.FirstContact", "");
ssSecondContact = r.ReadText(index++, "OrderDistributionImportStruc.SecondContact", "");
ssFirstApprover = r.ReadText(index++, "OrderDistributionImportStruc.FirstApprover", "");
ssSecondApprover = r.ReadText(index++, "OrderDistributionImportStruc.SecondApprover", "");
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
public void ReadIM(ST_eeea109a56651eacd7e36d2408b5b781Structure r) {
this = r;
}


public static bool operator == (ST_eeea109a56651eacd7e36d2408b5b781Structure a, ST_eeea109a56651eacd7e36d2408b5b781Structure b) {
if (a.ssDivision != b.ssDivision) return false;
if (a.ssApplicant != b.ssApplicant) return false;
if (a.ssApplicantDescription != b.ssApplicantDescription) return false;
if (a.ssDirection != b.ssDirection) return false;
if (a.ssFirstContact != b.ssFirstContact) return false;
if (a.ssSecondContact != b.ssSecondContact) return false;
if (a.ssFirstApprover != b.ssFirstApprover) return false;
if (a.ssSecondApprover != b.ssSecondApprover) return false;
return true;
}

public static bool operator != (ST_eeea109a56651eacd7e36d2408b5b781Structure a, ST_eeea109a56651eacd7e36d2408b5b781Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_eeea109a56651eacd7e36d2408b5b781Structure)) return false;
return (this == (ST_eeea109a56651eacd7e36d2408b5b781Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssDivision.GetHashCode()
 ^ ssApplicant.GetHashCode()
 ^ ssApplicantDescription.GetHashCode()
 ^ ssDirection.GetHashCode()
 ^ ssFirstContact.GetHashCode()
 ^ ssSecondContact.GetHashCode()
 ^ ssFirstApprover.GetHashCode()
 ^ ssSecondApprover.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_eeea109a56651eacd7e36d2408b5b781Structure Duplicate() {
ST_eeea109a56651eacd7e36d2408b5b781Structure t;
t.ssDivision = this.ssDivision;
t.ssApplicant = this.ssApplicant;
t.ssApplicantDescription = this.ssApplicantDescription;
t.ssDirection = this.ssDirection;
t.ssFirstContact = this.ssFirstContact;
t.ssSecondContact = this.ssSecondContact;
t.ssFirstApprover = this.ssFirstApprover;
t.ssSecondApprover = this.ssSecondApprover;
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
if (head == "division") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Division")) variable.Value = ssDivision; else variable.Optimized = true;
} else if (head == "applicant") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Applicant")) variable.Value = ssApplicant; else variable.Optimized = true;
} else if (head == "applicantdescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicantDescription")) variable.Value = ssApplicantDescription; else variable.Optimized = true;
} else if (head == "direction") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Direction")) variable.Value = ssDirection; else variable.Optimized = true;
} else if (head == "firstcontact") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstContact")) variable.Value = ssFirstContact; else variable.Optimized = true;
} else if (head == "secondcontact") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecondContact")) variable.Value = ssSecondContact; else variable.Optimized = true;
} else if (head == "firstapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstApprover")) variable.Value = ssFirstApprover; else variable.Optimized = true;
} else if (head == "secondapprover") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecondApprover")) variable.Value = ssSecondApprover; else variable.Optimized = true;
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
if (key == IdDivision) {
return ssDivision;
}
if (key == IdApplicant) {
return ssApplicant;
}
if (key == IdApplicantDescription) {
return ssApplicantDescription;
}
if (key == IdDirection) {
return ssDirection;
}
if (key == IdFirstContact) {
return ssFirstContact;
}
if (key == IdSecondContact) {
return ssSecondContact;
}
if (key == IdFirstApprover) {
return ssFirstApprover;
}
if (key == IdSecondApprover) {
return ssSecondApprover;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDivision.Key.AsGuid) {
return ssDivision;
}
if (attributeKey == IdApplicant.Key.AsGuid) {
return ssApplicant;
}
if (attributeKey == IdApplicantDescription.Key.AsGuid) {
return ssApplicantDescription;
}
if (attributeKey == IdDirection.Key.AsGuid) {
return ssDirection;
}
if (attributeKey == IdFirstContact.Key.AsGuid) {
return ssFirstContact;
}
if (attributeKey == IdSecondContact.Key.AsGuid) {
return ssSecondContact;
}
if (attributeKey == IdFirstApprover.Key.AsGuid) {
return ssFirstApprover;
}
if (attributeKey == IdSecondApprover.Key.AsGuid) {
return ssSecondApprover;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssDivision = (string) other.AttributeGet(IdDivision);
ssApplicant = (string) other.AttributeGet(IdApplicant);
ssApplicantDescription = (string) other.AttributeGet(IdApplicantDescription);
ssDirection = (string) other.AttributeGet(IdDirection);
ssFirstContact = (string) other.AttributeGet(IdFirstContact);
ssSecondContact = (string) other.AttributeGet(IdSecondContact);
ssFirstApprover = (string) other.AttributeGet(IdFirstApprover);
ssSecondApprover = (string) other.AttributeGet(IdSecondApprover);
}
} // ST_eeea109a56651eacd7e36d2408b5b781Structure
/// <summary>
/// RecordList type <code>OrderDistributionImportStrucList</code> that represents a record list of
///  <code>OrderDistributionImportStruc</code>
/// </summary>
public partial class RL_e5599d6b39ff4d762401f24c2e9326ab : GenericRecordList<ST_eeea109a56651eacd7e36d2408b5b781Structure>, IEnumerable, IEnumerator {

protected override ST_eeea109a56651eacd7e36d2408b5b781Structure GetElementDefaultValue() {
return new ST_eeea109a56651eacd7e36d2408b5b781Structure();
}

public T[] ToArray<T>(Func<ST_eeea109a56651eacd7e36d2408b5b781Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e5599d6b39ff4d762401f24c2e9326ab recordList, Func<ST_eeea109a56651eacd7e36d2408b5b781Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e5599d6b39ff4d762401f24c2e9326ab(ST_eeea109a56651eacd7e36d2408b5b781Structure[] array) {
  RL_e5599d6b39ff4d762401f24c2e9326ab result = new RL_e5599d6b39ff4d762401f24c2e9326ab();
result.InnerFromArray(array);
    return result;
}

public static RL_e5599d6b39ff4d762401f24c2e9326ab ToList<T>(T[] array, Func <T, ST_eeea109a56651eacd7e36d2408b5b781Structure> converter) {
  RL_e5599d6b39ff4d762401f24c2e9326ab result = new RL_e5599d6b39ff4d762401f24c2e9326ab();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e5599d6b39ff4d762401f24c2e9326ab FromRestList<T>(RestList<T> restList, Func <T, ST_eeea109a56651eacd7e36d2408b5b781Structure> converter) {
  RL_e5599d6b39ff4d762401f24c2e9326ab result = new RL_e5599d6b39ff4d762401f24c2e9326ab();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e5599d6b39ff4d762401f24c2e9326ab() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_eeea109a56651eacd7e36d2408b5b781Structure> NewList() {
return new RL_e5599d6b39ff4d762401f24c2e9326ab();
}


} // RL_e5599d6b39ff4d762401f24c2e9326ab
}

